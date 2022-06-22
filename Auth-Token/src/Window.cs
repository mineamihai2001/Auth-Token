using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth_Token.src
{
    public class Window
    {

        public static void Show(string title, string content)
        {
            Console.Write("**************\n" + title + "\n" + content);
        }

        public static void Clear()
        {
            Console.Clear();
        }
    }
}
