using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    public class Program
    {
        static int NumberToGuess = 0;
        static int totalGuesses = 0;
        // store user input
        static int userData = 0;

        static void Main(string[] args)
        {
            Random rng = new Random();
            // set number to guess
            SetNumberToGuess(rng.Next(1, 101));

            // run loop while user has not guessed the number
            while (userData != NumberToGuess)
            {
                
                // Prompt the user for a guess
                Console.Write("Ay, lets play a game! Guess the number between 1 and 100: ");
                string tempInput = Console.ReadLine();

                // Check if input is valid
                if (ValidateInput(tempInput))
                {
                    // Good input

                    // is it valid input?
                    if (userData == NumberToGuess)
                    {
                        Console.WriteLine("Well look at you, smartypants. Correct");
                    }
                    else
                    {
                        // when the user doesn't answer correctly
                        if (IsGuessTooHigh(userData))
                        {
                            //if answer is too high
                            //sing  corny lyrics, and tell them too high
                            Console.Write("Can you take me higher?? Sorry, Too high");
                            if (userData - NumberToGuess < 20)
                            {
                                Console.Write(", burning up\n");
                            }
                            else
                            {
                                Console.Write(", you're frozen\n");
                            }
                        }
                        else
                        {
                            // if it's  too low
                            //sing corny lyrics, and tell them too low
                            Console.Write("Lemme see you get low. Sorry, too low");
                            if (NumberToGuess - userData < 20)
                            {
                                Console.Write(", burning up\n");
                            }
                            else
                            {
                                Console.Write(", you're frozen\n");
                            }
                        }
                    }
                }
                else
                {
                    // Bad input
                    Console.WriteLine("Invalid input");
                }
            }

            Console.WriteLine("It took you  a whopping {0} guesses", totalGuesses);
            Console.ReadKey();

        }
        /// <summary>
        /// 
    
        /// <param name="userData"></param>
  
        /// <returns></returns>
        public static bool ValidateInput(string userData)
        {
            // check to see if it's null or empty
            if (userData != null || userData != string.Empty)
            {
                // 
                int intResult;
                if (int.TryParse(userData, out intResult))
                {
                  
                    // Check if it's within range (1 - 100)
                    if (intResult <= 100 && intResult >= 1)
                    {
                        // within range
                        totalGuesses++; // valid guess
                        Program.userData = intResult;
                        return true;
                    }
                }
            }
            return false;
        }
       
        /// </summary>
        /// <param name="number"></param>
        public static void SetNumberToGuess(int number)
        {
            //TODO: make this function override your global variable holding the number the user needs to guess.  This is used only for testing methods.
            NumberToGuess = number;

        }
        /// <summary>
        /// if the user guess is too high
        /// </summary>
        /// <param name="userGuess">what the user put in for a guess</param>
        /// <returns>true or false depending on rank of guess</returns>
        public static bool IsGuessTooHigh(int userGuess)
        {
            //TODO: return true if the number guessed by the user is too high
            if (NumberToGuess < userGuess)
            {
                return true;
            }
            return false;
            //return NumberToGuess < userGuess;

        }
        /// <summary>
        /// if the user guess is too low
        /// </summary>
        /// <param name="userGuess">the user guess</param>
        /// <returns>true or false depending on rank of guess</returns>
        public static bool IsGuessTooLow(int userGuess)
        {
            //TODO: return true if the number guessed by the user is too low
            if (userGuess < NumberToGuess)
            {
                return true;
            } 
            return false;
        }
    }
}
