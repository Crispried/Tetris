using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisLibrary
{
    public class Coordinate
    {
        private int value;

        public Coordinate(int value)
        {
            this.value = value;
        }

        public int Value
        {
            get
            {
                return value;
            }
        }
    }
}
