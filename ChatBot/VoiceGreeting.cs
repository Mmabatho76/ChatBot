using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace AzeeBotApp
{
  public class VoiceGreeting
    {
        private string voicegreeting;

        //constructor
        public VoiceGreeting(string greet)
        {
            voicegreeting = greet;
        }

        // Method to play the greeting
        public void Play()
        {
            try
            {
                SoundPlayer player = new SoundPlayer(voicegreeting);
                player.PlaySync(); // Waits until sound finishes
            }
            catch (Exception e)
            {
                Console.WriteLine("Error playing sound: " + e.Message);
            }
        }
    }
}

