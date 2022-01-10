using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class ConcreteUser : User
    {
        public ConcreteUser(string name, FacebookGroupMediator mediator)
            : base(name, mediator)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine(this.name + ": Received Message: " + message);
        }

        public override void Send(string message)
        {
            Console.WriteLine(this.name + ": Sending Message: " + message + "\n");
            mediator.SendMessage(message, this);
        }
    }
}
