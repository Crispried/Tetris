using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisLibrary;

namespace Console2DTetris
{
    public class GameController2D : GameController
    {
        public GameController2D(Mover2D mover, ShapeFactory shapeFactory,
                                ConsoleUI consoleUI) :
                                 base(mover, shapeFactory, consoleUI) { }

        public override void StartGame()
        {
            throw new NotImplementedException();
        }
    }
}
