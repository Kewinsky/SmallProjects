using System;
using System.Collections.Generic;
using System.Linq;

namespace hangman
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter a secret word: ");
            string word = Console.ReadLine();
            char[] hidden = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
                hidden[i] = '_';

            while (true)
            {
                char playerGuess;
                bool correctValue;
                do
                {
                    Console.Write("Letter: ");
                    correctValue = (char.TryParse(Console.ReadLine(), out playerGuess));
                    if (hidden.Contains(playerGuess))
                        Console.WriteLine("Choose another !");
                    else if (word.Contains(playerGuess))
                        Console.WriteLine("Correct!");
                    else
                        Console.WriteLine("Wrong...");

                } while (!correctValue);

                for (int j = 0; j < word.Length; j++)
                {
                    if (playerGuess == word[j])
                        hidden[j] = playerGuess;
                }


                if (!hidden.Contains('_') || playerGuess.ToString() == word)
                {
                    Console.WriteLine("You won :D");
                    break;
                }

                Console.WriteLine(hidden);
            }
        }
    }
}
