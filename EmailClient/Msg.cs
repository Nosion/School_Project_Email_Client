using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailClient
{
    public class Msg
    {
        public string MsgID { get; set; }
        public string MsgSender { get; set; }
        public string MsgSubject { get; set; }
        public string MsgBody { get; set; }
        public override string ToString()
        {
            return string.Format("MsgID: {0}, MsgSender: {1}, MsgSubject: {2}, MsgBody: {3}",
                MsgID, MsgSender, MsgSubject, MsgBody);
        }
    }
}
