using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace TcpServers
{
    public class PlanetTcpServer
    {
        private TcpListener listener;
        private TcpClient client;
        static CancellationTokenSource cts;

        // This event sends the received message to frmMain.
        // First string = message
        // Second string = client IP
        public event Action<string, string> MessageReceived;

        public void startServer(int port)
        {
            try
            {
                cts = new CancellationTokenSource();
                listener = new TcpListener(IPAddress.Any, port);
                listener.Start();

                Log.writeLog("Planet TCP server started on port " + port);

                while (!cts.IsCancellationRequested)
                {
                    if (listener.Pending())
                    {
                        using (client = listener.AcceptTcpClient())
                        using (NetworkStream stream = client.GetStream())
                        using (BinaryReader reader = new BinaryReader(stream, Encoding.UTF8, true))
                        {
                            string ip_client = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();

                            try
                            {
                                int messageLength = reader.ReadInt32();
                                byte[] RecData = reader.ReadBytes(messageLength);
                                string data = Encoding.UTF8.GetString(RecData);

                                Log.writeLog($"[{ip_client}]: {data}");

                                // Send the message to the form.
                                MessageReceived?.Invoke(data, ip_client);
                            }
                            catch (Exception ex)
                            {
                                Log.writeLog(ex.Message, Log.AlertType.error);
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
                Log.writeLog(ex.Message, Log.AlertType.error);
            }
            catch (Exception ex)
            {
                Log.writeLog(ex.Message, Log.AlertType.error);
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

    static public class Log
    {
        static int ProgramAlertLevel = 2;

        public enum AlertType
        {
            debug,
            info,
            warning,
            error
        }

        static Dictionary<AlertType, int> AlertLevel = new Dictionary<AlertType, int>
        {
            { AlertType.debug, 1 },
            { AlertType.info, 2 },
            { AlertType.warning, 3 },
            { AlertType.error, 4 }
        };

        static public void writeLog(string message, AlertType type = AlertType.info)
        {
            int level = AlertLevel[type];

            if (level < ProgramAlertLevel)
                return;

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            Console.WriteLine($"{timestamp} [{type}] {message}");
        }
    }
}