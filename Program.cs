namespace Assignment_7_Casino_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Maxym F.

            Part1();


        }
        public static void Part1()
        {



            Random generator = new Random();

            int points, coinSide, tries, heads, tails;
            string guess, keepGoing;

            coinSide = generator.Next(1, 3);

            bool done = false;

            Console.WriteLine("You start with 3 points. You lose one point every time you guess wrong, and you gain a point every guess thats correct. If you have 0 points, it's game over. So, Heads or Tails?");
            guess =Console.ReadLine().ToLower();

            //heads = 1;
            //tails = 2;

            points = 3;
            
            
            
            while (!done)
            {

                coinSide = generator.Next(1, 3)

                done = true;
                
                if (guess == "heads" && coinSide == 1)
                {
                    Console.WriteLine("Heads!");
                    Console.WriteLine("Correct!");
                    points++;

                }

                if (guess == "tails" && coinSide == 2)
                {
                    Console.WriteLine("Tails!");
                    Console.WriteLine("Correct!");
                    points++;
                }

                if (guess == "heads" && coinSide != 1) 
                {
                    Console.WriteLine("Tails!");
                    Console.WriteLine("Your Guess Was Inorrect!");
                    points--;
                }

                if (guess == "tails" && coinSide != 2) 
                { 
                    Console.WriteLine("Heads!");
                    Console.WriteLine("Your guess was Incorrect!");
                    points--;
                }
               
                Console.WriteLine("You now have " + points + " points.");
               
                Console.WriteLine("Would you like to continue? Yes or No?");
                keepGoing = Console.ReadLine().ToLower();

                if (keepGoing == "no" || keepGoing == "No") 
                {
                    Console.WriteLine("Okay, Goodbye.");
                    done = true;
                }

                if (keepGoing == "yes" || keepGoing == "Yes") 
                {
                    Console.WriteLine();
                    done = false;
                }

                if (points == 0) 
                {
                    Console.WriteLine("You have 0 points remaining. You lose.");
                    done = true;
                }

                
            }
        
        
        
        }
    }  
}
