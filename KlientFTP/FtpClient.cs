using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.ComponentModel;

namespace KlientFTP
{
    class FtpClient
    {
        public delegate void DownProgressChangedEventHandler(object sender, DownloadProgressChangedEventArgs e);
        public event DownloadProgressChangedEventHandler DownProgressChanged;

        protected virtual void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if (DownProgressChanged != null)
            {
                DownProgressChanged(sender, e);
            }
        }

        public delegate void DownCompletedEventHandler(object sender, AsyncCompletedEventArgs e);
        public event DownCompletedEventHandler DownCompleted;

        protected virtual void OnDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(DownCompleted != null)
            {
                DownCompleted(sender, e);
            }
        }

        #region Pola

        private string host;
        private string userName;
        private string password;
        private string ftpDirectory;
        private bool downloadCompleted;
        private bool uploadCompleted;

        #endregion


        #region Własności

        public string Host
        {
            get
            {
                return host;
            }
            set
            {
                host = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string FtpDirectory
        {
            get
            {
                if (ftpDirectory.StartsWith("ftp://"))
                    return ftpDirectory;
                else
                    return "ftp://" + ftpDirectory;
            }
            set
            {
                ftpDirectory = value;
            }
        }

        public bool DownloadCompleted
        {
            get
            {
                return downloadCompleted;
            }

            set
            {
                downloadCompleted = value;
            }
        }

        public bool UploadCompleted
        {
            get
            {
                return uploadCompleted;
            }

            set
            {
                uploadCompleted = value;
            }
        }

        #endregion


        #region Konstruktory

        public FtpClient()
        {
            downloadCompleted = true;
            uploadCompleted = true;
        }

        public FtpClient(string host, string userName, string password)
        {
            this.host = host;
            this.userName = userName;
            this.password = password;
            ftpDirectory = "ftp://" + this.host;
        }

        #endregion


        #region Metody

        public ArrayList GetDirectories()
        {
            ArrayList directories = new ArrayList();
            FtpWebRequest request;

            try
            {
                request = (FtpWebRequest)WebRequest.Create(ftpDirectory);
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                request.Credentials = new NetworkCredential(this.userName, this.password);
                request.KeepAlive = false;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    Stream stream = response.GetResponseStream();

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string directory;

                        while((directory = reader.ReadLine()) != null)
                        {
                            directories.Add(directory);
                        }
                    }
                }

                return directories;
            }
            catch
            {
                throw new Exception("Błąd: Nie można nawiązać połączenia z " + host);
            }
        }

        public ArrayList ChangeDirectory(string DirectoryName)
        {
            ftpDirectory += "/" + DirectoryName;
            return GetDirectories();
        }

        public ArrayList ChangeDirectoryUp()
        {
            if(ftpDirectory != "ftp://" + host)
            {
                ftpDirectory = ftpDirectory.Remove(ftpDirectory.LastIndexOf("/"), ftpDirectory.Length - ftpDirectory.LastIndexOf("/"));
                return GetDirectories();
            }
            else
            {
                return GetDirectories();
            }
        }

        public void DownloadFileAsync(string ftpFileName, string localFileName)
        {
            WebClient client = new WebClient();

            try
            {
                Uri uri = new Uri(FtpDirectory + "/" + ftpFileName);

                FileInfo file = new FileInfo(localFileName);

                if(file.Exists)
                {
                    throw new Exception("Błąd: Plik " + localFileName + " istnieje");
                }
                else
                {
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(Client_DownloadFileCompleted);
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Client_DownloadProgressChanged);

                    client.Credentials = new NetworkCredential(this.userName, this.password);

                    client.DownloadFileAsync(uri, localFileName);

                    downloadCompleted = false;
                }
            }
            catch
            {
                client.Dispose();

                throw new Exception("Błąd: Pobranie pliku niemożliwe");
            }
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.OnDownloadProgressChanged(sender, e);
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.OnDownloadCompleted(sender, e);
        }

        #endregion
    }
}
