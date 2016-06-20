using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisLibrary
{
    public abstract class Point
    {
        private List<Coordinate> coordinates;

        public Point(List<Coordinate> coordinates)
        {
            this.coordinates = coordinates;
        }

        public List<Coordinate> Coordinates
        {
            get
            {
                return coordinates;
            }
            set
            {
                coordinates = value;
            }
        }

        public bool Equals(Point point)
        {
            if(point == null)
            {
                return false;
            }
            if(coordinates.Count != point.Coordinates.Count)
            {
                return false;
            }
            for (int i = 0; i < coordinates.Count; i++)
            {
                if(coordinates[i].Value != point.Coordinates[i].Value)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
