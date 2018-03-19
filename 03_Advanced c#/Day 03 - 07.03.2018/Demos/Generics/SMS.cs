using System;

namespace Generics
{
    public class MMS<TSubject, TMessage> : SMS<TSubject, TMessage>
    // After Lesson 10
    // where TSubject : class where TMessage : struct
    {

    }

    public class SMS<TSubject, TMessage> 
        // After Lesson 10
        // where TSubject : class where TMessage: struct
    {
        public TSubject Subject;
        public TMessage Message;

        public SMS()
        {
        }

        public SMS(TSubject subject, TMessage message)
        {
            Subject = subject;
            Message = message;
        }

        public void Send(string phone)
        {
            Console.WriteLine("Sending Subject: {0}, Message: {1} to {2}", Subject, Message, phone);
        }
    }
}
