using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisLibrary;

namespace Console2DTetris
{
    public class GameField2D : GameField
    {
        private int height, width, topOffset, leftOffset;

        public GameField2D(int height, int width, int topOffset, int leftOffset)
        {
            this.height = height;
            this.width = width;
            this.topOffset = topOffset;
            this.leftOffset = leftOffset;
        }

        public int Height
        {
            get
            {
                return height;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int TopOffset
        {
            get
            {
                return topOffset;
            }
        }

        public int LeftOffset
        {
            get
            {
                return leftOffset;
            }
        }
    }
}
