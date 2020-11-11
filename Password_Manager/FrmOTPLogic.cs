using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Password_Manager
{
    class FrmOTPLogic
    {
        private static FrmOTPLogic instance;

        public static FrmOTPLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FrmOTPLogic();
                }
                return instance;
            }
        }

        private FrmOTPLogic() { }
        public string SendOtp(string phone)
        {
            Random rand = new Random();
            string otp = rand.Next(100000, 999999).ToString();
            string accountSid = "AC968a9be5608a4e80f36eba3e512e1e42";
            string authToken = "9e3d4151187dfc015620abbf2ad8bd12";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "your code is: " + otp,
                from: new Twilio.Types.PhoneNumber("+12569608438"),
                to: new Twilio.Types.PhoneNumber(phone)
            );
            return otp;
        }

    }
}
