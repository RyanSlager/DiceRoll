using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;

            while (cont == true)
            {
                string rawSides;
                int parSides;
                Random ran = new Random();

                Console.WriteLine("How many sides do your die have?\n");
                rawSides = Console.ReadLine();

                while (!Int32.TryParse(rawSides, out parSides))
                {
                    Console.WriteLine("Please enter a number greater than 0\n");
                    rawSides = Console.ReadLine();
                }

                Die dice1 = new Die(1, parSides, ran);
                Die dice2 = new Die(1, parSides, ran);

                int roll1 = dice1.DiceRoll();
                int roll2 = dice2.DiceRoll();

                dice1.TestSnakes(roll1, roll2);
                dice1.TestCars(roll1, roll2);
                dice1.TestCraps(roll1, roll2);

                cont = Continue();
            }
        }

        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("I'm sorry I don't understand. Let's try again");
                run = Continue();
            }
            return run;
        }
    }
}
