using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AzeeBotApp

{


    public class ChatBot
    {

        // Base chatbot class (Encapsulation)
        public string UserName { get; set; }
        public string BotName { get; set; } = "AzeeBot";

        public void GetUserName()
        {
            Console.Write("Enter your name: ");
            UserName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(UserName))
            {
                Console.Write("Please enter a valid name: ");
                UserName = Console.ReadLine();
            }
        }

        public void TypeMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(BotName + ": ");

            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }

            Console.WriteLine();
            Console.ResetColor();
        }

        public void TypingEffect()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(BotName + " is typing");

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(300);
                Console.Write(".");
            }

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
