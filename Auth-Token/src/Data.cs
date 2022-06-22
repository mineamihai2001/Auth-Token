using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth_Token.src
{
    public class Data
    {
        public string input { get; set; }
        public string output { get; set; }

        public void GetUserInput()
        {
            try
            {
                Window.Show("enter a command", ">>");
                input = Console.ReadLine();
                this.input = input;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public Command getInstance()
        {
            this.GetUserInput();
            CommandFactory commandFactory = new CommandFactory(this.input);
            return commandFactory.GetCommand();
        }

    }
}
