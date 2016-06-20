using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisLibrary
{
    public interface IMover
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shape">the shape which we want to move</param>
        /// <param name="direction">axis name on which we want to move our shape</param>
        /// <param name="value"></param>
        void Move(Shape shape, Axis axis, Direction direction);
    }
}
