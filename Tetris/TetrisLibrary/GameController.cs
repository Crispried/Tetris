using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisLibrary
{
    public abstract class GameController
    {
        IShapeFactory shapeFactory;
        IMover mover;
        UIController uiController;

        public GameController(IMover mover, IShapeFactory shapeFactory,
                                UIController controller)
        {
            this.mover = mover;
            this.shapeFactory = shapeFactory;
            this.uiController = controller;
        }

        public abstract void StartGame();       
    }
}
