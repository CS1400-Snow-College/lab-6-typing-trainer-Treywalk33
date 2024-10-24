using System;
using System.Diagnostics;
using System.Linq;

namespace TypingTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clear the screen
            Console.Clear();

            // Instructions
            Console.WriteLine("This is a typing trainer to help you practice typing. To start just start typing!");

            // Randomly select a challenge text
            string[] challengeTexts = {
                "The quick brown fox jumps over the lazy dog.",
                "Hello, world! How is y'alls day going?",
                "Practice makes perfect. So keep practicing tell you are were you want to be!",
                "Never give up, never surrender.",
                "A journey of a thousand miles begins with a single step."
            };
            Random random = new Random();
            string challengeText = challengeTexts[random.Next(challengeTexts.Length)];

            // Display the challenge text
            Console.WriteLine(challengeText);

            // Reposition the console cursor
            Console.SetCursorPosition(0, Console.CursorTop - 1);

           
        }
    }
}