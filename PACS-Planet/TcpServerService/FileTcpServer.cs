using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace TcpServerServices
{
    public class FileTcpServer
    {
        private bool _isRunning;
        public bool isRunning
        {
            get { return _isRunning; }
        }

        private Thread serverThread;
        private TcpListener listener;
        static CancellationTokenSource cts;

        private string rootStorageFIlePath;
        private void _startServer(int serverPort)
        {
            try
            {
                
                listener = new TcpListener(IPAddress.Any, serverPort);
                listener.Start();
                _isRunning = true;

                RaiseServerStatusChanged(
                    ServerStatus.Starting,
                    "Starting file server in port: " + serverPort
                );
                while (!cts.IsCancellationRequested)
                {
                    if (listener.Pending())
                    {
                        using (TcpClient client = listener.AcceptTcpClient())
                        using (NetworkStream stream = client.GetStream())
                        using (BinaryReader reader = new BinaryReader(stream, Encoding.UTF8, true))
                        {

                            string clientIp = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                            try
                            {
                                rootStorageFIlePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\FilesRecived");
                                if(!Directory.Exists(rootStorageFIlePath))
                                    Directory.CreateDirectory(rootStorageFIlePath);

                                string filePath = Path.Combine(rootStorageFIlePath, $"{DateTime.Now:yyyyMMdd_HHmmss}.bin");
                                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                                {
                                    byte[] buffer = new byte[4096];
                                    int bytesRead;
                                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                                    {
                                        fileStream.Write(buffer, 0, bytesRead);
                                    }
                                }
                                RaiseFileReceived(
                                    filePath,
                                    clientIp);
                            }
                            catch (Exception ex)
                            {
                                RaiseServerStatusChanged(
                                    ServerStatus.Error,
                                    ex.Message
                                );
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }

                }
            }
            catch (SocketException ex)
            {
                _isRunning = false;
                RaiseServerStatusChanged(
                    ServerStatus.Error,
                    ex.Message
                );
            }
            catch (Exception ex)
            {
                _isRunning = false;
                RaiseServerStatusChanged(
                    ServerStatus.Error,
                    ex.Message
                );
            }
            finally
            {
                listener?.Stop();
                _isRunning = false;
            }
        }
        public void startServer(int serverPort)
        {
            cts = new CancellationTokenSource();
            serverThread = new Thread(() => _startServer(serverPort));
            serverThread.IsBackground = true;
            serverThread.Start();
        }
        public void stopServer()
        {
            _isRunning = false;
            cts?.Cancel();
            serverThread.Join(2000);
            RaiseServerStatusChanged(
                ServerStatus.Closing,
                "Closing server"
            );
        }

        #region Event ServerStatusChanged
        public event EventHandler ServerStatusChanged;
        public class ServerStatusEventArgs : EventArgs
        {
            public ServerStatus Status { get; set; }
            public string Message { get; set; }
        }
        protected virtual void OnServerStatusChanged(ServerStatusEventArgs e)
        {
            if (null != ServerStatusChanged)
            {
                ServerStatusChanged(this, e);
            }
        }
        private void RaiseServerStatusChanged(ServerStatus status, string message)
        {
            this.OnServerStatusChanged(new ServerStatusEventArgs
            {
                Status = status,
                Message = message
            });
        }
        #endregion
        #region Event FileReceived
        public event EventHandler FileReceived;
        public class DataReceivedEventArgs : EventArgs
        {
            public string FilePath { get; set; }
            public string ClientIp { get; set; }
        }
        protected virtual void OnFileReceived(DataReceivedEventArgs e)
        {
            if (null != FileReceived)
            {
                FileReceived(this, e);
            }
        }

        private void RaiseFileReceived(string rawData, string clientIp)
        {
            this.OnFileReceived(new DataReceivedEventArgs
            {
                FilePath = rawData,
                ClientIp = clientIp
            });
        }
        #endregion
    }
}
