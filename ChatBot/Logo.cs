using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzeeBotApp
{
    internal class Logo
    {

        public void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
╔══════════════════════════════════════════════════════╗
║                 🤖 AZEEBOT SYSTEM                   ║
╠══════════════════════════════════════════════════════╣
║        _____ _____  _____  ______ _____              ║
║       / ____|  __ \|  __ \|  ____|  __ \             ║
║      | (___ | |  | | |__) | |__  | |  | |            ║
║       \___ \| |  | |  _  /|  __| | |  | |            ║
║       ____) | |__| | | \ \| |____| |__| |            ║
║      |_____/|_____/|_|  \_\______|_____/             ║
║                                                      ║
║         Cybersecurity Awareness Chatbot              ║
║            Stay Safe. Stay Smart.                    ║
╚══════════════════════════════════════════════════════╝
");
            Console.ResetColor();
        }
    }
}
