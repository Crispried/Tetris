using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisLibrary
{
    public abstract class UIController
    {
        private GameField gameField;

        public UIController(GameField gameField)
        {
            this.gameField = gameField;
        }

        public abstract void DrawGameField();
    }
}
