using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth_Token.src.Commands
{
    public class ListUsers
    {
        List<User> users;
        
        // add all the users from the DB to the list
        public ListUsers()
        {
            users = new List<User>();
        }

        public void List()
        {/*
            foreach (var user in users)
            {
                Window.Show("", user._id);
            }*/
        }

    }
}
