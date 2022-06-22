using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth_Token.src
{
    public class CommandFactory
    {
        private string _command;

        public CommandFactory(string command)
        {
            _command = command;
        }

        public Command GetCommand()
        {
            switch (this._command)
            {
                case "login":
                    return new Login();
                case "logout":
                    return new Logout();
                default: return null;
            }
        }
    }
}
