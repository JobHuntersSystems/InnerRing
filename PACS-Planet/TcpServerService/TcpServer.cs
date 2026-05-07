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
using PACS_Common;
using System.Text.RegularExpressions;

namespace TcpServerServices
{
    public class TcpServerService
    {
        private bool _isRunning;
        public bool isRunning
        {
            get { return _isRunning; }
        }

        private Thread serverThread;
        private TcpListener listener;
        static CancellationTokenSource cts;
        public List<string> clientsIPList { get; private set; }

        public TcpServerService()
        {
            clientsIPList = new List<string>();
        }
        #region Helpers
        private void identifyMessageType(string message, string ip_client)
        {
            if (Regex.IsMatch(message, @"^ER.{24}$"))
            {
                SendMessageEvent($"{ip_client} | " + message, LogLevel.Success);
                SendProtocolEvent(MessageType.ER, message, ip_client);
            }
            else if (Regex.IsMatch(message,@"^VR.{24}$"))
            {
                SendMessageEvent($"{ip_client} | " + message, LogLevel.Success);
                SendProtocolEvent(MessageType.VR, message, ip_client);
            }
            else
            {
                SendMessageEvent(
                   $"{ip_client} | " + message,
                   LogLevel.Success
                );
            }
        }
        #endregion
        private void _startServer(int serverPort)
        {
            try
            {
                cts = new CancellationTokenSource();

                listener = new TcpListener(IPAddress.Any, serverPort);
                listener.Start();
                _isRunning = true;
                SendInfoEvent(
                   "Init server in port: " + serverPort,
                   LogLevel.Info
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

                            if (!clientsIPList.Contains(clientIp))
                            {
                                clientsIPList.Add(clientIp);
                                SendMessageEvent(
                                    $"new client connected: {clientIp}",
                                    LogLevel.Success
                                );
                            }
                            else
                            {
                                SendMessageEvent(
                                    $"Welcome Again {clientIp}",
                                    LogLevel.Success
                                );
                            }

                            try
                            {
                                int messageLength = reader.ReadInt32();
                                byte[] RecData = reader.ReadBytes(messageLength);
                                string data = Encoding.UTF8.GetString(RecData);

                                identifyMessageType(data, clientIp);
                            }
                            catch (Exception ex)
                            {
                                SendMessageEvent(
                                    ex.Message,
                                    LogLevel.Error
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
                SendMessageEvent(
                    ex.Message,
                    LogLevel.Error
                );
            }
            catch (Exception ex)
            {
                _isRunning = false;
                SendMessageEvent(
                    ex.Message,
                    LogLevel.Error
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
            serverThread = new Thread(() => _startServer(serverPort));
            serverThread.Start();
        }
        public void stopServer()
        {
            _isRunning = false;
            cts?.Cancel();

            SendInfoEvent(
               "Closing server",
                LogLevel.Warn
            );
        }

        #region Event InfoMessage
        public event EventHandler infoMessage;
        public class InfoEventArgs : EventArgs
        {
            public string Message { get; set; }
            public LogLevel Level { get; set; }
        }
        protected virtual void OnInfoMessage(InfoEventArgs e)
        {
            if (null != infoMessage)
            {
                infoMessage(this, e);
            }
        }
        private void SendInfoEvent(string msg, LogLevel level)
        {
            this.OnInfoMessage(new InfoEventArgs
            {
                Message = msg,
                Level = level
            });
        }
        #endregion
        #region Event SendMessage
        public event EventHandler SendMessage;
        public class MessageEventArgs : EventArgs
        {
            public string Message { get; set; }
            public LogLevel Level { get; set; }
        }
        protected virtual void OnSendMessage(MessageEventArgs e)
        {
            if (null != SendMessage)
            {
                SendMessage(this, e);
            }
        }
        private void SendMessageEvent(string msg, LogLevel level)
        {
            this.OnSendMessage(new MessageEventArgs
            {
                Message = msg,
                Level = level
            });
        }
        #endregion
        #region Event ProtocolMessage
        public event EventHandler ProtocolMessage;
        public class ProtocolEventArgs : EventArgs
        {
            public MessageType MessageType { get; set; }
            public string RawData { get; set; }
            public string ClientIp { get; set; }
        }
        protected virtual void OnProtocolMessage(ProtocolEventArgs e)
        {
            if (null != ProtocolMessage)
            {
                ProtocolMessage(this, e);
            }
        }
        private void SendProtocolEvent(MessageType msgType, string rawData, string clientIp)
        {
            this.OnProtocolMessage(new ProtocolEventArgs
            {
                MessageType = msgType,
                RawData = rawData,
                ClientIp = clientIp
            });
        }

        #endregion

    }
}
