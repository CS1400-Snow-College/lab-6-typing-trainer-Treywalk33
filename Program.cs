//Trey Walker, 10/23/24, Typing lab
using System;
using System.Diagnostics;
using System.Linq;

namespace TypingTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();

          
            Console.WriteLine("Type the following text:");

            
            string[] challengeTexts = {
                "The quick brown fox jumps over the lazy dog.",
                "Hello, world!",
                "Practice makes perfect.",
                "Never give up, never surrender.",
                "A journey of a thousand miles begins with a single step."
            };
            Random random = new Random();
            string challengeText = challengeTexts[random.Next(challengeTexts.Length)];

            
            Console.WriteLine(challengeText);

            
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            
            int correctCharacters = 0;
            int incorrectCharacters = 0;

        
            
            foreach (char expectedChar in challengeText)
            {
                
                char inputChar = Console.ReadKey(true).KeyChar;

                if (inputChar == expectedChar)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    correctCharacters++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    incorrectCharacters++;
                }

                Console.Write(inputChar);

                Console.ResetColor();
            }

           
        }
    }
}