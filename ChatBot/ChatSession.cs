using System;
using System.Threading;

namespace AzeeBotApp
{
    // Chat logic class (Inheritance)
    public class ChatSession : ChatBot
    {
        private string currentTopic = ""; // tracks where user is

        public void StartChat()
        {
            TypeMessage("Hello " + UserName + " Welcome to Cybersecurity Awareness!");
            TypeMessage("You can chat with me or use the menu.");
            TypeMessage("Type 'back' anytime to go back.");

            bool running = true;

            while (running)
            {
                // ===== MENU LEVEL =====
                if (currentTopic == "")
                {
                    ShowMenu();
                    Console.Write(UserName + ": ");
                    string input = Console.ReadLine().ToLower();

                    TypingEffect();

                    if (input == "1" || input.Contains("purpose"))
                        currentTopic = "purpose";

                    else if (input == "2" || input.Contains("password"))
                        currentTopic = "password";

                    else if (input == "3" || input.Contains("phishing"))
                        currentTopic = "phishing";

                    else if (input == "4" || input.Contains("browse") || input.Contains("website"))
                        currentTopic = "browsing";

                    else if (input == "5" || input.Contains("exit") || input.Contains("bye"))
                    {
                        TypeMessage("Goodbye " + UserName + " Stay Safe Online!");
                        running = false;
                    }
                    else
                    {
                        TypeMessage("Hmm... choose a topic from the menu.");
                    }
                }

                // ===== TOPIC LEVEL =====
                else
                {
                    ShowTopicQuestions();

                    Console.Write(UserName + ": ");
                    string input = Console.ReadLine().ToLower();

                    TypingEffect();

                    // BACK LOGIC
                    if (input == "back")
                    {
                        currentTopic = "";
                        continue;
                    }

                    // HANDLE QUESTIONS
                    HandleTopicQuestions(input);
                }
            }
        }

        // ================= MENU =================
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

        // ================= SHOW QUESTIONS =================
        private void ShowTopicQuestions()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (currentTopic == "purpose")
            {
                Console.WriteLine("\n--- Purpose Questions ---");
                Console.WriteLine("1. What do you do?");
                Console.WriteLine("2. How can you help me with cybersecurity?");
                Console.WriteLine("3. Are you a real person or a bot?");
                Console.WriteLine("4. Why were you created?");
                Console.WriteLine("5. What problems can you solve?");
            }
            else if (currentTopic == "password")
            {
                Console.WriteLine("\n================= Password Questions ==================");
                Console.WriteLine("\n1. How do I create a strong password?");
                Console.WriteLine("2. Is it safe to use the same password everywhere?");
                Console.WriteLine("3. How often should I change my password?");
                Console.WriteLine("4. What is a password manager?");
                Console.WriteLine("5. Can hackers guess my password easily?");
                Console.WriteLine("\n========================================================");
            }
            else if (currentTopic == "phishing")
            {
                Console.WriteLine("\n============= Phishing Questions =====================");
                Console.WriteLine("\n1. What is phishing?");
                Console.WriteLine("2. How can I tell if an email is fake?");
                Console.WriteLine("3. What should I do if I clicked a phishing link?");
                Console.WriteLine("4. Can phishing happen on WhatsApp or SMS?");
                Console.WriteLine("5. Why do hackers use phishing attacks?");
                Console.WriteLine("\n=======================================================");
            }
            else if (currentTopic == "browsing")
            {
                Console.WriteLine("\n============== Browsing Questions ================");
                Console.WriteLine("\n1. How do I know if a website is safe?");
                Console.WriteLine("2. What does https mean?");
                Console.WriteLine("3. Is public Wi-Fi safe?");
                Console.WriteLine("4. Can I get hacked by visiting a website?");
                Console.WriteLine("5. What browser is safest?");
                Console.WriteLine("\n===================================================");
            }

            Console.WriteLine("\n(Type 'back' to return)");
            Console.ResetColor();
        }

        // ================= ANSWERS =================
        private void HandleTopicQuestions(string input)
        {
            // ===== PURPOSE =====
            if (currentTopic == "purpose")
            {
                if (input.Contains("what do you do"))
                    TypeMessage("I help users understand cybersecurity and stay safe online.");

                else if (input.Contains("help"))
                    TypeMessage("I give tips on passwords, phishing, and safe browsing.");

                else if (input.Contains("real"))
                    TypeMessage("I am a chatbot , not a human.");

                else if (input.Contains("why"))
                    TypeMessage("I was created to spread cybersecurity awareness.");

                else if (input.Contains("problems"))
                    TypeMessage("I help prevent hacking, scams, and unsafe online behavior.");

                else
                    TypeMessage("Ask one of the listed questions ");
            }

            // ===== PASSWORD =====
            else if (currentTopic == "password")
            {
                if (input.Contains("create"))
                    TypeMessage("Steps to Create a Safe Password\r\r\n" +
                        "Ensure your password is at least 12 characters long. " +
                        "Aim for 16-18 characters for enhanced security." +
                        "\r\n\r\nUse a combination of uppercase and lowercase letters, numbers, and " +
                        "special characters (e.g., @, #, $)." +
                        "\r\n\r\nAvoid using personal information such as your name, birthday, or pet's name." +
                        "\r\n\r\nCombine unrelated words to form a passphrase (e.g., \"SeashellBattery$123\")." +
                        "\r\n\r\nAvoid dictionary words or predictable patterns (e.g., \"Password123\") and " +
                        "common substitutions like \"H0use\"." +
                        "\r\n\r\nConsider using a memorable sentence and taking the first letter of each word, " +
                        "adding numbers and symbols (e.g., \"I love hiking in 2023!\" becomes \"Ilh!2023\")." +
                        "\r\n\r\nUse a password manager to generate and store strong, unique passwords for each account." +
                        "\r\n\r\nRegularly update your passwords and avoid reusing them across multiple accounts.\n");

                else if (input.Contains("same"))
                    TypeMessage("No! Using the same password for multiple accounts is not safe and " +
                        "significantly increases your risk of cyber attacks, including credential stuffing " +
                        "and identity theft." +
                        "\r\n\rRisks of Using the Same Password\r\n\rCredential Stuffing: This is a common attack where " +
                        "cybercriminals use stolen login credentials from one site to gain access to accounts on other sites. " +
                        "If you use the same password across multiple platforms, a breach on one site can compromise all your " +
                        "accounts. \r\n\r\nIdentity Theft: Reusing passwords can lead to severe consequences, including financial" +
                        " loss and identity theft. If a hacker gains access to one of your accounts, they can potentially access " +
                        "sensitive information across all your accounts, including banking and personal data. " +
                        "\r\n\r\nWeak Passwords: Many users tend to create weak and easily memorable passwords, which are often " +
                        "reused. This practice makes it easier for attackers to guess or crack your passwords, especially if they " +
                        "are based on personal information. \r\n\r");

                else if (input.Contains("often"))
                    TypeMessage("Change passwords every few months or if compromised.");

                else if (input.Contains("manager"))
                    TypeMessage("A password manager stores and generates secure passwords.");

                else if (input.Contains("hackers"))
                    TypeMessage("Yes, weak passwords can be guessed easily using tools.");

                else
                    TypeMessage("Ask one of the listed password questions.");
            }

            // ===== PHISHING =====
            else if (currentTopic == "phishing")
            {
                if (input.Contains("what"))
                    TypeMessage("Phishing is a scam to trick you into giving personal info.");

                else if (input.Contains("email"))
                    TypeMessage("Check spelling, sender address, and suspicious links.");

                else if (input.Contains("clicked"))
                    TypeMessage("Disconnect from internet and change your passwords immediately.");

                else if (input.Contains("whatsapp") || input.Contains("sms"))
                    TypeMessage("Yes! Phishing can happen through messages too.");

                else if (input.Contains("why"))
                    TypeMessage("Hackers use phishing because it's easy and effective.");

                else
                    TypeMessage("Ask one of the listed phishing questions.");
            }

            // ===== BROWSING =====
            else if (currentTopic == "browsing")
            {
                if (input.Contains("safe"))
                    TypeMessage("Look for HTTPS and a lock icon in the browser.");

                else if (input.Contains("https"))
                    TypeMessage("HTTPS means the site is encrypted and more secure.");

                else if (input.Contains("wifi"))
                    TypeMessage("Public Wi-Fi is risky. Avoid logging into accounts on it.");

                else if (input.Contains("hacked"))
                    TypeMessage("Yes, malicious sites can infect your device.");

                else if (input.Contains("browser"))
                    TypeMessage("Use updated browsers like Chrome, Edge, or Firefox.");

                else
                    TypeMessage("Ask one of the listed browsing questions.");
            }
        }
    }
}