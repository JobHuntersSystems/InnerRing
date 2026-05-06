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
using EventsClass;
using PACS_Common;

namespace TcpClientServices
{
    public class TcpClientService
    {
        List<string> public_ips = new List<string>()
        {
            "1.1.1.1",        // Cloudflare primary
            "1.0.0.1",        // Cloudflare secondary
            "8.8.8.8",        // Google DNS primary
            "8.8.4.4",        // Google DNS secondary
        };

        private CommunicationEventClass cl;
        public TcpClientService(CommunicationEventClass communicationEvents)
        {
            this.cl = communicationEvents;
        }
        public void checkConnection(string hostIp)
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
                                cl.SendTcpEvent(
                                    message,
                                    "",
                                    LogLevel.Success
                                );
                            }
                        }
                        catch (Exception)
                        {
                            string message = $"Ping to {ip} - NOK";
                            cl.SendTcpEvent(
                                    message,
                                    "",
                                    LogLevel.Success
                                );
                            networkAvaible = false;
                            throw new Exception($"Error Connection: Ping to {ip} not respond");
                        }
                    }
                    reply = myPing.Send(hostIp, 1000);
                    if (reply.Address != null)
                    {
                        string message = $"Ping to Host: {hostIp} - OK";
                        cl.SendTcpEvent(
                            message,
                            "",
                            LogLevel.Success
                        );
                    }
                }
            }
            catch(Exception ex)
            {
                cl.SendTcpEvent(
                  ex.Message,
                  "",
                  LogLevel.Error
              );
            }
        }
        public void sendMessage(string hostIp, int hostPort,string message)
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
                        writer.Write(dades.Length);
                        writer.Write(dades);
                    }
                }
            }
            catch (Exception ex)
            {
                cl.SendTcpEvent(
                    ex.Message,
                    "",
                    LogLevel.Error
                );
            }
        }
    }
}
