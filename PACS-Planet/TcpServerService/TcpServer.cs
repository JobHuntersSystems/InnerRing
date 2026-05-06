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
using EventsClass;
using PACS_Common;

namespace TcpServerServices
{
    public class TcpServerService
    {
        private TcpListener listener;

        private bool _isRunning;
        public bool isRunning
        {
            get { return _isRunning; }
        }
        static CancellationTokenSource cts;

        private CommunicationEventClass cl;

        public TcpServerService(CommunicationEventClass communicationEvents)
        {
            this.cl = communicationEvents;
        }
        
        public void startServer(int serverPort)
        {
            try
            {
                isRunning = true;

                cts = new CancellationTokenSource();

                listener = new TcpListener(IPAddress.Any, serverPort);
                listener.Start();
                _isRunning = true;
                cl.SendTcpEvent(
                   "Init server in port: " + serverPort,
                   "",
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
                            cl.SendTcpEvent(
                                "Client connected",
                                clientIp,
                                LogLevel.Success
                            );

                            try
                            {
                                int messageLength = reader.ReadInt32();
                                byte[] RecData = reader.ReadBytes(messageLength);
                                string data = Encoding.UTF8.GetString(RecData);
                                cl.SendTcpEvent(
                                    data,
                                    clientIp,
                                    LogLevel.Info
                                );
                            }
                            catch (Exception ex)
                            {
                                _isRunning = false;
                                cl.SendTcpEvent(
                                    ex.Message,
                                    clientIp,
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
                cl.SendTcpEvent(
                    ex.Message,
                    "",
                    LogLevel.Error
                );
            }
            catch (Exception ex)
            {
                _isRunning = false;
                cl.SendTcpEvent(
                    ex.Message,
                    "",
                    LogLevel.Error
                );
            }
            finally
            {
                listener?.Stop();
                _isRunning = false;
            }
        }
        public void stopServer()
        {
            _isRunning = false;
            cts?.Cancel();
   
            cl.SendTcpEvent(
               "Closing server",
                "",
                LogLevel.Warn
            );
        }
       
    }
}
