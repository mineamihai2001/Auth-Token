using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth_Token.src
{
    public class User
    {
        private int _id { get; set; }
        private string _username { get; set; }
        private string _token { get; set; }

        public User(int id, string username, string token)
        {
            this._id = id;
            this._username = username;
            this._token = token;
        }


    }
}
