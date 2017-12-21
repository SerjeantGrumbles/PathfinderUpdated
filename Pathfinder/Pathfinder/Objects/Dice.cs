using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder
{
    public static class Dice
    {
        private static Random rollDice = new Random();

        public static int d4()
        {
            return rollDice.Next(1, 5);
        }

        public static int d6()
        {
            return rollDice.Next(1, 7);
        }

        public static int d8()
        {
            return rollDice.Next(1, 9);
        }

        public static int d10()
        {
            return rollDice.Next(1, 11);
        }

        public static int d12()
        {
            return rollDice.Next(1, 13);
        }

        public static int d20()
        {
            return rollDice.Next(1, 21);
        }
    }
}
