using System;

namespace Deliverable2
{
    class Program
    {
        public static void Main()
        {
            // Ask for new conversation
            Console.WriteLine("What would you like to say to the Bot?");
            string BotChat = " ";
            string InputHuman = " ";

            bool FirstEntry = true;

            string Again = " ";

            do
            {
                if (FirstEntry != true)
                {   // prompt for new response
                    Console.WriteLine("What else would you like to say to the Bot?");
                }
                FirstEntry = false;

                // ToLower
                InputHuman = Console.ReadLine().ToLower();

                // applying responses
                if (InputHuman == "hello")
                {
                    BotChat = "Hi good to see you";
                }
                else if (InputHuman == "bye")
                {
                    BotChat = "Goodbye!";
                }
                else if (InputHuman == "sup")
                {
                    BotChat = "I am good";
                }
                else if (InputHuman == "hello there")
                {
                    BotChat = "General Kenobi";
                }


                // if (Again == String.Copy(InputHuman))
                // if (String.ReferenceEquals(InputHuman, Again))

                if (Again == InputHuman)
                {
                    BotChat = "I'm sorry but you have already said that";
                }

                // produce response
                Console.WriteLine(BotChat);
                Again = InputHuman;
            }

            while (InputHuman != "bye");

        }
    }
}

