using System;

namespace Guess4MysteruNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that picks a random number between
            //1 and 10.Give the user 4 chances to guess the number.
            //If the user guesses the number, display “You won"; otherwise,
            //display “You lost". (To make sure the program is behaving correctly,
            //you can display the secret number on the console first.)
            var random = new Random();
            var randomnumber = random.Next(1, 10);
           
           
            var numberOfGuesses = 4;

            for (var i = 0; i <= 3; i++)
            {
                Console.WriteLine("Please choose a number between 1-10 and see if you can guess the mystery #");
                var input = Convert.ToInt32(Console.ReadLine());

                if (randomnumber == input)
                {
                    Console.WriteLine("You win!!! The Mystery number was {0}!", randomnumber);
                    break;
                }
                else if (input != randomnumber)
                {
                    numberOfGuesses--;
                   

                    if(numberOfGuesses==0)
                    {
                        Console.WriteLine("You lose, better luck next time");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Guess again you have {0} guesses left", numberOfGuesses);
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer");
                }
            }
        }
    }
}
