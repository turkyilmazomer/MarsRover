using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Plateau
    {
        private static Plateau plateau;
        static object lockObject = new object();

        public static Plateau Create(string title, Coordinate coordinate)
        {
            lock (lockObject)
            {
                if (plateau == null)
                {
                    plateau = new Plateau(title, coordinate);
                }
            }
            return plateau;
        }

        public string Title { get; set; }

        public Coordinate Coordinate { get; set; }

        private Plateau(string title, Coordinate coordinate)
        {
            this.Title = title;
            this.Coordinate = coordinate;
        }


    }
}
