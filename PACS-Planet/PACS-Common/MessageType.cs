using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACS_Common
{
    public enum MessageProtocolType
    {
        ER, //Entry Request
        VK, //Validation Key
        Message
    }
    public enum ResultType
    {
        VP,
        AD,
        UNK
    }
}
