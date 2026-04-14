using AzeeBotApp;
using System;
using System.Threading;

namespace AzeeBotApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create VoiceGreeting object and load the audio file
            VoiceGreeting sound = new VoiceGreeting(@"voicegreeting.wav");
            sound.Play();// Play the welcome audio greeting

            // Create Logo object to display ASCII art logo
            Logo logo = new Logo();
            logo.DisplayLogo(); // Display the chatbot logo in the console

            // Create ChatSession object (main chatbot logic)
            ChatSession bot = new ChatSession();
            bot.GetUserName();
            bot.StartChat();
            
        }
    }
}
