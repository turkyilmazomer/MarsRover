using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Plateau
    {
      

        public string Title { get; set; }

        public Coordinate Coordinate { get; set; }

        public Plateau(string title, Coordinate coordinate)
        {
            this.Title = title;
            this.Coordinate = coordinate;
        }


    }
}
