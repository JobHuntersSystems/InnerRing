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

namespace TcpServerService
{
    public class PlanetTcpServer
    {
        private TcpListener listener;
        private TcpClient client;
        static CancellationTokenSource cts;
        public void startServer(int port)
        {
            try
            {
                cts = new CancellationTokenSource();
                listener = new TcpListener(IPAddress.Any, port);
                listener.Start();

                while (!cts.IsCancellationRequested)
                {
                    if (listener.Pending())
                    {
                        using (client = listener.AcceptTcpClient())
                        using (NetworkStream stream = client.GetStream())
                        using (BinaryReader reader = new BinaryReader(stream, Encoding.UTF8, true))
                        {
                            string ip_client = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                            //Log.writeLog($"{ip_client} Client Connected...");
                            try
                            {
                                int messageLength = reader.ReadInt32();
                                byte[] RecData = reader.ReadBytes(messageLength);
                                string data = Encoding.UTF8.GetString(RecData);
                                Console.WriteLine(data);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
        }
    }
}
