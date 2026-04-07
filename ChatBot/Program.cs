using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatBot
{
    internal class Program
    {
        class chatBot
        {
            public string name { get; set; }
            public string response { get; set; }
            public string BotName { get; set; }


            public chatBot()
            {
                BotName = "AzeeBot";
            }


            public void userInput()
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                while (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Please enter a valid name: ");
                    name = Console.ReadLine();
                }
            }

            public void MessageInput(string message)
            {
                foreach (char m in message)
                {
                    Console.WriteLine(m);
                    Thread.Sleep(20);
                }
                Console.WriteLine();
            }

            public void TypingEffect()
            {
                Console.WriteLine(BotName + "is typing");
                for (int i = 0; i < 3; i++)
                {
                   Thread.Sleep(300);
                    Console.Write(".");
                }

            }

            class questions : chatBot
            {
                public void displayMenu()
                {

                    Console.WriteLine("\nHi " + name + " ,Welcome to Cybersecurity , I hope i will be able to assist you where needed\n");

                    bool chatting = true;

                    while (chatting)
                    {
                        Console.WriteLine("\n==========CHATBOT MENU==========\n");
                        Console.WriteLine("1.What is your purpose? ");
                        Console.WriteLine("2.Pssword Safety Tips");
                        Console.WriteLine("3.Phishing Awareness");
                        Console.WriteLine("4.Safe Browsing Tips");
                        Console.WriteLine("5.Exit");
                        Console.WriteLine("===================================\n");

                        Console.Write(name + ":");
                        response = Console.ReadLine().ToLower();

                        TypingEffect();

                    if(response.Contains("1")|| response.Contains("purpose"))
                    {
                            Console.WriteLine(BotName + ": I am just here to help you to be safe online.");
   
                    }
                    else if (response.Contains("2") || response.Contains("password"))
                    {
                            Console.WriteLine(BotName + ": Passwords should be unique");
                            Console.WriteLine(BotName + ": Include letters, numbers and symbols.");
                    }
                    else if (response.Contains("3") || response.Contains("phishing"))
                    {
                        Console.WriteLine(BotName + ": Phishing is a type of cyberattack where attackers impersonate legitimate entities to deceive individuals into revealing sensitive information, such as passwords and credit card numbers.");
                    }
                    else if (response.Contains("4") || response.Contains("safe browsing") || response.Contains("browse"))
                    {
                        Console.WriteLine(BotName + ": Only use secure websites(HTTPS).");
                    }
                    else if(response.Contains("5") || response.Contains("exit") || response.Contains("bye"))
                    {
                            Console.WriteLine(BotName + ": Goodbye " + name + "Stay Safe Online");
                            chatting = false;
                    }
                    else
                        {
                            Console.WriteLine(BotName + ":I do not quite understand. Please ask questions regarding cybersecurity");
                        }

                    }
                }
            }
            static void Main(string[] args)
            {
                questions bot = new questions();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"
╔══════════════════════════════════════════════════════╗
║              CYBERSECURITY SYSTEM                    ║
╠══════════════════════════════════════════════════════╣
║        _____ _____  _____  ______ _____              ║
║       / ____|  __ \|  __ \|  ____|  __ \             ║
║      | (___ | |  | | |__) | |__  | |  | |            ║
║       \___ \| |  | |  _  /|  __| | |  | |            ║
║       ____) | |__| | | \ \| |____| |__| |            ║
║      |_____/|_____/|_|  \_\______|_____/             ║
║                                                      ║
║                 AZEEBOT - CYBERSECURITYBOT           ║
║            Stay Safe. Stay Smart.                    ║
╚══════════════════════════════════════════════════════╝
");

                Console.ResetColor();

                bot.userInput();
                bot.displayMenu();
            }
        }
    }
}
