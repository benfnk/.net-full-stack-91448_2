using System;

namespace WaitHandleObject
{
    class Email
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public Email(string email, string subject, string body)
        {
            EmailAddress = email;
            Subject = subject;
            Body = body;
        }

        public void Send()
        {
            Console.WriteLine("Sending email to: {0}, subject: {1}, body: {2}", EmailAddress, Subject, Body);
        }
    }
}
