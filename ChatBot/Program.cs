using System;
using System.Threading;

namespace AzeeBotApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Logo logo = new Logo();
            logo.DisplayLogo();
            ChatSession bot = new ChatSession();
            bot.GetUserName();
            bot.StartChat();
        }
    }
}
