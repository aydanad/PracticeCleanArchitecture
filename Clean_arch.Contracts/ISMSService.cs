using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Contracts
{
    public interface ISMSService
    {
        void SendSMS(SMSBody body);
    }
    public class SMSBody
    {
        public  string PhoneNamber { get; set; }
        public string Message { get; set; }
    }
}
