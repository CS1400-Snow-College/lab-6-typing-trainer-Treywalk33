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
            double elapsedTimeInSeconds = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
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

            stopwatch.Stop();
            elapsedTimeInSeconds = stopwatch.ElapsedMilliseconds / 1000.0;

            
            double accuracy = (correctCharacters / (correctCharacters + incorrectCharacters)) * 100;
            int totalWords = challengeText.Split(' ').Length;
            double wordsPerMinute = (totalWords - incorrectCharacters) / (elapsedTimeInSeconds / 60);

           
            Console.WriteLine("\n");
            Console.WriteLine($"Accuracy: {accuracy:N2}%");
            Console.WriteLine($"Elapsed time: {elapsedTimeInSeconds:N2} seconds");
            Console.WriteLine($"Words per minute: {wordsPerMinute:N2}");
        }
    }
}