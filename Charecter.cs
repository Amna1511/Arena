using System;
using System.Collections.Generic;
using System.Text;

namespace Arena
{
   
        public class Character
        {
        
        public string name;
       public int score = 0;
   

        public int Health = 75;// { get; set; }
            public Character()
            {

            }
        public Character(string c_name)
            {
            name = c_name;
    
             }
        public Character(string c_name, int c_health, int score)
            {
                name = c_name;
                Health = c_health;
                
            }
            public int dice()
            {

                Random r = new Random();
                Console.Write(" Press any key to Rool a dice it will become ur strength:");
                Console.ReadLine();
                int b = r.Next(1, 7);
                Console.WriteLine(" {0}", b);
                return b;
            }
        //Character[] emp = new Character[10];
        //int index = 0;
        public void GetData()
        {
            string name;
            Console.WriteLine("Enter Player:");
            name = Console.ReadLine();
            this.name = name;
           // emp[index] = new Character(name);
           //index++;
        }
        public void ShowData()
        {
            Console.WriteLine("Name\t Score\t Health");
            Console.WriteLine(" {0}\t {1}\t {2}", name, score, Health);
        }

    }
}
