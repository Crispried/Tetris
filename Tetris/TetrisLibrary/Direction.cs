using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisLibrary
{
    /// <summary>
    /// When you determine positive direction type
    /// it means, that you will increase by 1 your coordinate,
    /// when you determine negative direction type
    /// it means, that you will decrease by 1 your coordinate
    /// </summary>
    public enum DirectionType
    {
        Positive, Negative
    }
    public class Direction
    {
        private DirectionType directionType;

        public Direction(DirectionType directionType)
        {
            this.directionType = directionType;
        }

        public DirectionType GetDirectionType
        {
            get
            {
                return directionType;
            }
        }
    }
}
