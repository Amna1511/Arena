using System;
using System.IO;
namespace Arena
{
    class Program
    {
        public static void GetHealth(Character player1, Character player2)
        {
            if (player1.Health == 50 && player2.Health==75)
            {
                Console.WriteLine(" {0} Player Retires", player1.name);
            }
            else if (player2.Health == 50 && player1.Health==75)
            {
                Console.WriteLine(" {0} Player Retires", player2.name);
            }
            else if (player1.Health == 50 && player2.Health == 50)
            {
                Console.WriteLine(" {0}, {1} Both Players are equally retired", player1.name, player2.name);
            }
            else if (player1.Health == 25)
            {
                Console.WriteLine(" {0} cant play more, You need energy ", player1.name);
            }
            else if (player2.Health == 25)
            {
                Console.WriteLine(" {0} cant play more, You need energy ", player2.name);
            }
        }
        
        static void Purchase()
        {
            Console.WriteLine("1:Health Back to 75");
            Console.WriteLine("2:Strength back");
        }
       static void Play()
        {
            do
            {

                //int count2 = 0;
                Character player1 = new Character();
                Character player2 = new Character();
                //int score1 = 0;
                //int score2 = 0;
                player1.GetData();
                player2.GetData();

                for (int i = 0; i < 2; i++)
                {

                    int a = player1.dice();
                    int b = player2.dice();
                    Random random = new Random();
                    int result = random.Next(1, 7);
                    Console.ReadLine();
                    Console.WriteLine("dice for compitition: {0}: ", result);

                    if ((a + result) > (b + result))
                    {

                        player2.Health = player2.Health - 25;
                        player1.score += 10;
                        Console.WriteLine(" {0} is winner\t Score {1}.", player1.name, player1.score);
                        GetHealth(player1, player2);
                    }
                    else if ((a + result) < (b + result))
                    {
                        player1.Health = player1.Health - 25;
                         player2.score = player2.score+ 10;
                        Console.WriteLine(" {0} is winner\t Score {1}.", player2.name, player2.score);
                        GetHealth(player1, player2);

                    }
                    else
                    {
                        Console.WriteLine(" {0} and {1} both are equal", player1.name, player2.name);
                    }
                }
                player1.ShowData();
                player2.ShowData();
 
                Console.WriteLine("You want to continue?Press Y/N");
            }
            while (Console.ReadLine().ToUpper() == "Y");
        }
        static void Main(string[] args)
        {
            
        
            //String filePath = @"C:\Users\Lexicon\source\repos";
            //lines.add("amna");
            //File.WriteAllLines(filePath, lines);
            bool value = true;
            while (value)
            {
                Console.WriteLine("=============Main Menu============");
                Console.WriteLine("1:You want to play a game.Select 1");
                Console.WriteLine("2:purchase gift");
                Console.WriteLine("3:quit");
                Console.WriteLine("Enter your choice");
                int ch = Int32.Parse(Console.ReadLine());

                switch (ch)
                {

                    case 1:
                    Play();
                        break;
                    case 2:
                        Purchase();
                        break;
                    case 3:
                        value = false;
                        break;

                }
            
        }
            
    }
        
       
   }
}

