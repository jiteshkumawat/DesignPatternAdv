using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FacebookGroupMediator facebookGroupMediator = new FacebookGroupMediator();

            User jitesh = new ConcreteUser("Jitesh", facebookGroupMediator);
            User neha = new ConcreteUser("Neha", facebookGroupMediator);
            User robin = new ConcreteUser("Robin", facebookGroupMediator);

            facebookGroupMediator.RegisterUser(jitesh);
            facebookGroupMediator.RegisterUser(neha);
            facebookGroupMediator.RegisterUser(robin);

            jitesh.Send("We are starting up with mediator design pattern.");
            neha.Send("Please help with Q&A");

            Console.ReadLine();
        }
    }
}
