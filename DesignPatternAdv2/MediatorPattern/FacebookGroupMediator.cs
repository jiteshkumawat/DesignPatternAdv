using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class FacebookGroupMediator : IFacebookGroupMediator
    {
        private List<User> usersList = new List<User>();
        public void RegisterUser(User user)
        {
            usersList.Add(user);
        }

        public void SendMessage(string msg, User user)
        {
            foreach(var u in usersList)
            {
                if(u != user)
                {
                    u.Receive(msg);
                }
            }
        }
    }
}
