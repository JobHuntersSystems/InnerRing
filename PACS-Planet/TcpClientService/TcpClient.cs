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
using System.Net.NetworkInformation;
using PACS_Common;

namespace TcpClientServices
{
    public class TcpClientService
    {
        private List<string> public_ips = new List<string>()
        {
            "1.1.1.1",        // Cloudflare primary
            "1.0.0.1",        // Cloudflare secondary
            "8.8.8.8",        // Google DNS primary
            "8.8.4.4",        // Google DNS secondary
        };
        private Thread clientThread;
        private void _checkConnection(string hostIp)
        {
            bool networkAvaible = true;
            try
            {
                networkAvaible = NetworkInterface.GetIsNetworkAvailable();
                if (networkAvaible)
                {
                    Ping myPing = new Ping();
                    PingReply reply;
                    foreach (var ip in public_ips)
                    {
                        try
                        {
                            reply = myPing.Send(ip, 1000);
                            if (reply.Address != null)
                            {
                                string message = $"Ping to {ip} - OK";
                                RaiseNotificationSent(
                                     LogLevel.Success, message
                                );
                            }
                        }
                        catch (Exception)
                        {
                            string message = $"Ping to {ip} - NOK";
                            RaiseNotificationSent(
                                LogLevel.Success, message
                            );
                            networkAvaible = false;
                            throw new Exception($"Error Connection: Ping to {ip} not respond");
                        }
                    }
                    reply = myPing.Send(hostIp, 1000);
                    if (reply.Address != null)
                    {
                        string message = $"Ping to Spaceship: {hostIp} - OK";
                        RaiseNotificationSent(
                            LogLevel.Success, message
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                RaiseNotificationSent(
                  LogLevel.Error, ex.Message
              );
            }
        }
        private void _sendFile(string hostIp, int hostPort, string localFilePath)
        {
            try
            {
                if (!File.Exists(localFilePath))
                    throw new Exception($"File not found: {localFilePath}");

                using (TcpClient client = new TcpClient(hostIp, hostPort))
                {
                    client.SendTimeout = 5000;
                    client.ReceiveTimeout = 5000;
                    
                    using (NetworkStream ns = client.GetStream())
                    using (BinaryWriter writer = new BinaryWriter(ns, Encoding.UTF8, true))
                    {
                        using (FileStream fileStream = new FileStream(localFilePath, FileMode.Open, FileAccess.Read))
                        {
                            byte[] buffer = new byte[4096];
                            int bytesRead;
                            RaiseNotificationSent(LogLevel.Warn, $"Sending zip: {localFilePath}");
                            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                ns.Write(buffer, 0, bytesRead);
                            }
                            RaiseNotificationSent(LogLevel.Success, $"File Sent");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                RaiseNotificationSent(
                  LogLevel.Error, ex.Message
                );
            }
        }
        private void _sendMessage(string hostIp, int hostPort, string message)
        {
            try
            {
                using (TcpClient client = new TcpClient(hostIp, hostPort))
                {
                    client.SendTimeout = 5000;
                    client.ReceiveTimeout = 5000;
                    using (NetworkStream ns = client.GetStream())
                    using (BinaryWriter writer = new BinaryWriter(ns, Encoding.UTF8, true))
                    {
                        byte[] dades = Encoding.UTF8.GetBytes(message);

                        if (dades.Length > 1024 * 1024)
                        {
                            throw new Exception("Message overweight ✘");
                        }
                        RaiseNotificationSent(LogLevel.Info, $"Sending: {message}");
                        writer.Write(dades.Length);
                        writer.Write(dades);
                    }
                }
            }
            catch (Exception ex)
            {
                RaiseNotificationSent(
                    LogLevel.Error, ex.Message
                );
            }
        }
        public void sendFile(string hostIp, int hostPort, string localFilePath)
        {
            clientThread = new Thread(() => _sendFile(hostIp, hostPort, localFilePath));
            clientThread.Start();
        }

        public void sendMessage(string hostIp, int hostPort, string message)
        {
            clientThread = new Thread(() => _sendMessage(hostIp, hostPort, message));
            clientThread.Start();
        }
        public void checkConnection(string hostIp)
        {
            clientThread = new Thread(() => _checkConnection(hostIp));
            clientThread.Start();
        }

        #region Event NotificationSent
        public event EventHandler NotificationSent;
        public class NotificationSentEventArgs : EventArgs
        {
            public string Message { get; set; }
            public LogLevel Level { get; set; }
        }
        protected virtual void OnNotificationSent(NotificationSentEventArgs e)
        {
            if (null != NotificationSent)
            {
                NotificationSent(this, e);
            }
        }
        private void RaiseNotificationSent(LogLevel level, string msg)
        {
            this.OnNotificationSent(new NotificationSentEventArgs
            {
                Message = msg,
                Level = level
            });
        }
        #endregion
    }
}
