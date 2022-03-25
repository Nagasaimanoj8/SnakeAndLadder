using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChecksForaOption
{
    internal class Program
    {
        public const int NoPlay = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        /// <summary>
        /// RollsDie generates number from 1 to 6.
        /// </summary>
        /// <returns></returns>
        public static int rollDie()
        {
            // Create Reference for Random class
            Random random = new Random();
            int numberOnDie = random.Next(1, 7);
            return numberOnDie;
        }
        /// <summary>
        /// News the position.
        /// </summary>
        /// <param name="numberOnDie">The number on die.</param>
        /// <returns></returns>
        public static int newPosition(int numberOnDie)
        {
            int addNumber = 0;
            Random random = new Random();
            int optionCheck = random.Next(0, 3);
            //Options for player.
            switch (optionCheck)
            {
                case NoPlay:
                    Console.WriteLine("No play!");
                    break;
                case Ladder:
                    addNumber = numberOnDie;
                    Console.WriteLine("Taken Ladder, so moving forward!");
                    break;
                case Snake:
                    addNumber = -numberOnDie;
                    Console.WriteLine("Bitten by Snake, so moving backward!");
                    break;
            }
            return addNumber;
        }
        static void Main(string[] args)
        {
            //Variable
            int currentPosition = 0;
            Console.WriteLine("Welcome to Snake and Ladder Problem!");
            Console.WriteLine("Starting position: " + currentPosition);
            int numberOnDie = rollDie();
            Console.WriteLine("Number on the die rolled is : " + numberOnDie);
            Console.WriteLine("New position is: " + newPosition(numberOnDie));
            Console.ReadKey();
        }
    }
}
    

