using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzeeBotApp

// Chat logic class (Inheritance)
{
    public class ChatSession : ChatBot
    {
        public void StartChat()
        {
            TypeMessage("Hello " + UserName + " 👋 Welcome to Cybersecurity Awareness!");
            TypeMessage("You can chat with me or use the menu.");

            bool running = true;

            while (running)
            {
                ShowMenu();
                Console.Write(UserName + ": ");
                string input = Console.ReadLine().ToLower();

                TypingEffect();

                if (input.Contains("1") || input.Contains("purpose"))
                {
                    TypeMessage("I help you stay safe online by teaching cybersecurity basics.");
                }
                else if (input.Contains("2") || input.Contains("password"))
                {
                    TypeMessage("Use strong and unique passwords.");
                    TypeMessage("Mix letters, numbers, and symbols.");
                }
                else if (input.Contains("3") || input.Contains("phishing"))
                {
                    TypeMessage("Phishing is when attackers trick you into giving personal info.");
                    TypeMessage("Always verify emails and links before clicking.");
                }
                else if (input.Contains("4") || input.Contains("browse"))
                {
                    TypeMessage("Only visit secure websites (HTTPS).");
                    TypeMessage("Avoid downloading files from unknown sources.");
                }
                else if (input.Contains("5") || input.Contains("exit") || input.Contains("bye"))
                {
                    TypeMessage("Goodbye " + UserName + " 👋 Stay Safe Online!");
                    running = false;
                }
                else
                {
                    TypeMessage("Hmm... I didn't understand that 🤔");
                    TypeMessage("Try asking about passwords, phishing, or browsing.");
                }
            }
        }

        private void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n========== AZEEBOT MENU ==========");
            Console.WriteLine("1. What is your purpose?");
            Console.WriteLine("2. Password Safety Tips");
            Console.WriteLine("3. Phishing Awareness");
            Console.WriteLine("4. Safe Browsing Tips");
            Console.WriteLine("5. Exit");
            Console.WriteLine("==================================\n");
            Console.ResetColor();
        }
    }
}
