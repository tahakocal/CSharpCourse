using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsBaseLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms ile loglandi");
        }
    }
}
