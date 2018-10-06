using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    /// <summary>
    /// The author is Robert Lute
    /// getrobertajob@gmail.com
    /// 719-310-0055
    /// 
    /// This is a Magic 8 Ball program displayed in the console. 
    /// </summary>
    class Program
{
static void Main(string[] args)
{
            // Preserve current console text color
            ConsoleColor oldColor = Console.ForegroundColor;

            // Calls fuction to create title
            Title();

            // Creat a randomizer object
            Random randomObject = new Random();
           
            // Loop for questions and answers
            while (true)
            {
                string questionString = UserInput();

                int ThinkTimer = randomObject.Next(4) + 1;
                Console.WriteLine("Thinking about your answer, stand by....");
                Thread.Sleep(ThinkTimer * 1000);

                if( questionString.Length == 0)
                {
                    Console.WriteLine("You didn't ask a question yet.");
                    continue;
                }


                // check if user typed 'quit' as the question
                if (questionString.ToLower() == "quit")
                {
                    break;
                }

                // Get a random #
                int randomNumber = randomObject.Next(6);

                // Use random number to determine an answer
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("YES!");
                            break;
                        }
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("NO!");
                            break;
                        }
                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("MOST LIKELY");
                            break;
                        }
                    case 3:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("REPLY HAZY, TRY AGAIN LATER");
                            break;
                        }
                    case 4:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("IT IS CERTAIN");
                            break;
                        }
                    case 5:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("DON'T COUNT ON IT");
                            break;
                        }
                }
            }

            // Cleaning up
            Console.ForegroundColor = oldColor;
        }

        /// <summary>
        /// Print the name of the program and who created it to the console
        /// <summary/>
        static void Title()
        {
            // Change console text color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Magic 8 Ball (by: Robert)");
        }

        /// <summary>
        /// Function to get user input
        /// </summary>
        static string UserInput()
        {
            // This block of code will ask the user for a question 
            // and store the question text in questionString variable
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ask a question?: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            String questionString = Console.ReadLine();

            return questionString;
        }
    }
}
