using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public abstract class User
    {
        protected string name;
        protected FacebookGroupMediator mediator;

        public User(string name, FacebookGroupMediator mediator)
        {
            this.name = name;
            this.mediator = mediator;
        }

        public abstract void Send(string message);

        public abstract void Receive(string message);
    }
}
