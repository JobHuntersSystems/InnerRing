using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using PACS_Common;

namespace EventsClass
{
    public class CommunicationEventClass
    {
        public class TcpEventArgs : EventArgs
        {
            public string Message { get; set; }
            public string ClientIp { get; set; }
            public LogLevel Level { get; set; }
        }

        public event EventHandler SendMessage;

        public void SendTcpEvent(string msg, string ip, LogLevel level)
        {
            this.OnSendMessage(new TcpEventArgs
            {
                Message = msg,
                ClientIp = ip,
                Level = level
            });
        }

        protected virtual void OnSendMessage(TcpEventArgs e)
        {
            if (null != SendMessage)
            {
                SendMessage(this, e);
            }
        }
    }
}
