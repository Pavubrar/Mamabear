using System;

namespace Mamabear
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();
            //nt correctNumber = 7;

            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;
                Console.WriteLine("Guess number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    //get user input
                    string input = Console.ReadLine();

                    // Make sure its a number 

                    if (!int.TryParse(input, out guess))
                    {
                        /*onsole.ForegroundColor = ConsoleColor.Red;
                         Console.WriteLine("Please enter a number"); 
                        Console.ResetColor();*/
                        // print error message 
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number");
                        continue;
                    }

                    //covert guess input into int

                    guess = Int32.Parse(input);

                    // math guess to correct number

                    if (guess != correctNumber)
                    {
                        /*onsole.ForegroundColor = ConsoleColor.Red;
                        
                         Console.WriteLine("Wrong number, please try again");
                        Console.ResetColor(); */
                         PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }
                // output succes message
                PrintColorMessage(ConsoleColor.Green,"Youare correct..!!");
                /*onsole.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine("You are correct..!!");  
                 Console.ResetColor();*/

                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                 if(answer == "Y")
                {
                    continue;
                } else if (answer =="N")
                {
                    return;
                }else
                {
                    return;
                }

            
            }

        }
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Parveen Kaur";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Version{1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
        static void GreetUser()
        {
            //ask user's name
            Console.WriteLine("What is youre name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game..", inputName);
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
        }
    }
}
