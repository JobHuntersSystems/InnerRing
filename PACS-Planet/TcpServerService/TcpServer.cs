using System;
using System.Collections.Generic;
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
        private TcpClient client;
        private bool isRunning;
        static CancellationTokenSource cts;

        private CommunicationEventClass cl;

        public TcpServerService(CommunicationEventClass communicationEvents)
        {
            this.cl = communicationEvents;
        }
        
        public void startServer(int port)
        {
            try
            {
                isRunning = true;

                cts = new CancellationTokenSource();
                listener = new TcpListener(IPAddress.Any, port);
                listener.Start();

                cl.SendTcpEvent(
                   "Init server in port: " + port,
                   "",
                   LogLevel.Info
               );
                while (!cts.IsCancellationRequested)
                {
                    if (listener.Pending())
                    {
                        using (client = listener.AcceptTcpClient())
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
                                isRunning = false;
                                cl.SendTcpEvent(
                                    ex.Message,
                                    clientIp,
                                    LogLevel.Error
                                );
                                break;
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
                isRunning = false;
                cl.SendTcpEvent(
                    ex.Message,
                    "",
                    LogLevel.Error
                );
            }
            catch (Exception ex)
            {
                isRunning = false;
                cl.SendTcpEvent(
                    ex.Message,
                    "",
                    LogLevel.Error
                );
            }
            finally
            {
                listener?.Stop();

            }
        }

        public void stopServer()
        {
            cts?.Cancel();
            client?.Close();
            listener?.Stop();
            isRunning = false;
            cl.SendTcpEvent(
               "Closing server",
                "",
                LogLevel.Info
            );
        }
       
    }
}