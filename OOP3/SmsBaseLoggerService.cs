using System;

namespace OOP3
{
    class SmsBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms ile loglandi");
        }
    }
}
