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
            public string response;

            public void userInput()
            {
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();

                Console.ReadLine();
            }
        }

        class questions : chatBot
        {
            public void display()
            {
                Console.WriteLine("Hi " + name + "Welcome to Cybersecurity , I hope i will be able to assist you where needed");

                while(string.IsNullOrEmpty(name))
                {
                    Console.Write("Enter your name: ");
                    name = Console.ReadLine();

                }

                Console.WriteLine("\n==========CHATBOT MENU==========\n");
                Console.WriteLine("1.what is your purpose? ");
                Console.WriteLine("2.passwords");
                Console.WriteLine("3.phishing");
                Console.WriteLine("4.exit");

                while (!string.IsNullOrEmpty(name))
                {
                    Console.Write("\n" + name + ": ");
                    response = Console.ReadLine().ToLower();

                    if(response == "1")
                    {
                        Console.WriteLine(" I am just here to help you to be safe online");
                    }else if(response == "2")
                    {
                        Console.WriteLine("Passwords should be unique");
                    }else if (response == "3")
                    {
                        Console.WriteLine("Phishing is a type of cyberattack where attackers impersonate legitimate entities to deceive individuals into revealing sensitive information, such as passwords and credit card numbers.");
                    }else if(response == "4")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("I do not quite understand. Please ask questions regarding cybersecurity");
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            questions bot = new questions();

            Console.WriteLine("Hi , Welcome to CyberSecurity Quizz...\n");

            bot.userInput();
            bot.display();
        }
    }
}
