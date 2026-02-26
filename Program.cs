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
            
            int score, coinSide, tries;
            
            coinSide = generator.Next(1, 3);

            Console.WriteLine("Heads or Tails?");
            

            if (coinSide == 1) 
            {
                Console.WriteLine("Heads!");
            }

            if (coinSide == 2) 
            {
                Console.WriteLine("Tails!");
            }
        
        
        
        
        }
    }  
}
