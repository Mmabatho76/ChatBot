 AzeeBot - Cybersecurity Awareness Chatbot

 Overview

AzeeBot is a console-based chatbot application developed in C#.
Its main purpose is to educate users about cybersecurity awareness, including topics such as:

- Password safety
- Phishing attacks
- Safe browsing practices

The chatbot provides an interactive experience using menus, typing effects, and even a voice greeting.

======================================================================================================

 Features

  Voice Greeting

  - Plays a ".wav" audio file when the program starts.

  ASCII Logo Display

  - Displays a styled chatbot banner in the console.

  Interactive Chat System

  - Users can enter their name and chat with the bot.
  - Menu-driven navigation for easy use.

  Cybersecurity Topics Covered
  
  - Purpose of the chatbot
  - Password safety tips
  - Phishing awareness
  - Safe browsing tips

  Typing Animation

  - Simulates real-time typing for a better user experience.

  Navigation Support

  - Users can type "back" to return to the main menu.

==================================================================================

 Project Structure

AzeeBotApp/
│
├── Program.cs          # Entry point of the application
├── ChatBot.cs          # Base class (handles typing effects & user input)
├── ChatSession.cs      # Main chatbot logic (inherits from ChatBot)
├── VoiceGreeting.cs    # Handles audio playback
├── Logo.cs             # Displays ASCII art logo
├── voicegreeting.wav   # Audio file for greeting

====================================================================================

 OOP Concepts Used

This project demonstrates key Object-Oriented Programming principles:

Encapsulation

  - Properties like "UserName" and "BotName" are managed within the "ChatBot" class.

Inheritance

  - "ChatSession" inherits from "ChatBot" to reuse functionality.

Abstraction

  - Complex chatbot logic is broken into methods like:

    - "StartChat()"
    - "HandleTopicQuestions()"

====================================================================================

 How It Works

1. The program starts in "Program.cs"
2. A voice greeting is played
3. The logo is displayed
4. User enters their name
5. Chatbot starts interaction:

   - Displays menu
   - User selects a topic
   - Bot answers questions based on the selected topic

==================================================================================

How to Run the Project

 Requirements:

- Visual Studio / any C# IDE
- .NET Framework or .NET Core

Steps:

1. Open the project in Visual Studio
2. Ensure "voicegreeting.wav" is in the correct directory:
   bin/Debug/
3. Build the solution
4. Run the application

===================================================================================

 Notes

- Make sure the ".wav" file path is correct, otherwise audio will not play.
- The chatbot relies on keyword matching (e.g., "password", "phishing").

===================================================================================

 Future Improvements

- Add more cybersecurity topics
- Improve natural language understanding
- Add GUI (Windows Forms or WPF)
- Integrate real-time threat data or APIs

==================================================================================

Author

Developed by Mmabatho Vilakazi

===================================================================================

Reference list:
- Wikipedia, 2026. HTTPS. [online] Available at: <https://en.wikipedia.org/wiki/HTTPS> [Accessed 13 April 2026].
- Comodo cWatch, 2026. Check Website Reputation / Site Scan. [online] Available at: <https://cwatch.comodo.com/site-scan/check-website-reputation.php>
  [Accessed 12April 2026].
- Boston University, 2026. How to identify and protect yourself from an unsafe website. [online] Available at: <https://www.bu.edu/tech/support/information-security/security-for-everyone/how-to-identify-and-protect-yourself-from-an-unsafe-website/> [Accessed 11 April 2026].
- McAfee, 2026. 8 ways to know if online stores are safe and legit. [online] Available at: <https://www.mcafee.com/learn/8-ways-to-know-if-online-stores-are-safe-and-legit/> [Accessed 10 April 2026].
  
