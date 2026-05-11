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
    public class DataTcpServer
    {
        private bool _isRunning;
        public bool isRunning
        {
            get { return _isRunning; }
        }

        private Thread serverThread;
        private TcpListener listener;
        static CancellationTokenSource cts;

        private void _startServer(int serverPort)
        {
            try
            {
                
                listener = new TcpListener(IPAddress.Any, serverPort);
                listener.Start();
                _isRunning = true;

                RaiseServerStatusChanged(
                    ServerStatus.Starting,
                    "Starting data server in port: " + serverPort
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
                                int messageLength = reader.ReadInt32();
                                byte[] RecData = reader.ReadBytes(messageLength);
                                string data = Encoding.UTF8.GetString(RecData);

                                RaiseDataReceived(data,clientIp);
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
            serverThread.Start();
        }
        public void stopServer()
        {
            _isRunning = false;
            cts?.Cancel();

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
        #region Event DataReceived
        public event EventHandler DataReceived;
        public class DataReceivedEventArgs : EventArgs
        {
            public string RawData { get; set; }
            public string ClientIp { get; set; }
        }
        protected virtual void OnDataReceived(DataReceivedEventArgs e)
        {
            if (null != DataReceived)
            {
                DataReceived(this, e);
            }
        }

        private void RaiseDataReceived(string rawData, string clientIp)
        {
            this.OnDataReceived(new DataReceivedEventArgs
            {
                RawData = rawData,
                ClientIp = clientIp
            });
        }
        #endregion
    }
}
