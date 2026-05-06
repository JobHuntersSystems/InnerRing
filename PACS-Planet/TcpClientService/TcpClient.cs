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
            "9.9.9.9",        // Quad9 primary
            "149.112.112.112", // Quad9 secondary
            "208.67.222.222",  // OpenDNS primary
            "208.67.220.220",  // OpenDNS secondary
            "4.2.2.1",        // Level3 primary
            "4.2.2.2"         // Level3 secondary
        };
        Boolean networkAvaible;
        string currentIP;
        int currentPort;

        TcpClient client;
        NetworkStream ns;
        public bool testConnection()
        {
            networkAvaible = true;
           
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
                           
                        }
                    }
                    catch (Exception)
                    {
                        string message = $"Ping to {ip} - NOK";
                      
                        throw new Exception($"Error Connection: Ping to {ip} not respond");
                    }
                }
            }
            return networkAvaible;
        }
      
        public void verifyConnection()
        {
            bool networkStatus = false;
            try
            {
                networkStatus = testConnection();


                if (currentIP != null && currentPort != 0)
                {
                    client = new TcpClient();
                    client.SendTimeout = 5000;
                    client.ReceiveTimeout = 5000;
                    client.Connect(currentIP, currentPort);
                    ns = client.GetStream();
                }
                else
                {
                    throw new Exception("Undefined IP addresse or port in xml setting file ✘");
                }
            }
            catch (IOException ex)
            {
               
            }
            catch (SocketException ex)
            {
              
            }
            catch (Exception ex)
            {
              
            }

        }
        public void sendMessage(string message)
        {
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
        public void closeConexion()
        {
            if (ns != null)
                ns.Close();

            if (client != null)
                client.Close();
        }


    }
}
