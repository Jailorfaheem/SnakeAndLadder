﻿using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of snake and ladder");
            Console.WriteLine();
            Console.WriteLine("Single Player mode: Starting position 0");
            Console.WriteLine("START GAME");

            //Variables
            int position = 0;

            Random die = new Random();
            int dice = die.Next(1, 7);
            Console.WriteLine("The number on this die roll is: " + dice);

        }
    }
}