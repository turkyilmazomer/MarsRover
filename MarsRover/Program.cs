﻿using System;
using System.Collections.Generic;
using System.Linq;



namespace MarsRover
{
    class Program
    {

        static void Main(string[] args)
        {
            
            var plateau = Plateau.Create("Mars",new Coordinate(5,5));

            Rover rover1 = new Rover(plateau, new Coordinate(1,2), Direction.N);
            rover1.Start("LMLMLMLMM");
            Rover rover2 = new Rover(plateau, new Coordinate(3, 3), Direction.E);
            rover2.Start("MMRMMRMRRM");


            Console.WriteLine("Test Input:\n5 5\n1 2 N\nLMLMLMLMM\n3 3 E\nMMRMMRMRRM\n\nExpected Output :");
            Console.WriteLine($"{rover1.Coordinate.X} {rover1.Coordinate.Y} {rover1.Direction.ToString()}");
            Console.WriteLine($"{rover2.Coordinate.X} {rover2.Coordinate.Y} {rover2.Direction.ToString()}");




            Console.ReadLine();
        }



    }
}
