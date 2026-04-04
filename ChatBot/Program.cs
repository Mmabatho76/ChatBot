using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    internal class Program
    {
        class chatBot
        {
            public string name;

            public void userInput()
            {
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();


                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            chatBot Bot = new chatBot();
            Bot.userInput();
        }
    }
}
