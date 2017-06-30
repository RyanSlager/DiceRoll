using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    class Die
    {
        private int min;
        private int max;
        private Random ran;

        public Die(int min, int max, Random ran)
        {
            this.min = min;
            this.max = max;
            this.ran = ran;
        }

        public int DiceRoll()
        { 

            int x = ran.Next(min, max);

            Console.WriteLine($"You rolled a {x}!");

            return x;

        }

        public void TestSnakes(int x, int y)
        {
            if(x == y && x == 1 && y == 1)
            {
                Console.WriteLine("Snake Eyes!!!");
            }   
        }
        
        public void TestCraps(int x, int y)
        {
            int roll = x + y;

            if(roll == 2 || roll == 3 || roll == 12)
            {
                Console.WriteLine("CRAPS!!!!");
            }
        }

        public void TestCars(int x, int y)
        {
            if(x == 6 && y == 6)
            {
                Console.WriteLine("BoxCars!");
            }
        }

    }
}
