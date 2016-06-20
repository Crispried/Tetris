using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisLibrary;

namespace Console2DTetris
{
    public class ConsoleUI : UIController
    {
        private char boarderPart = '#';

        private int height, width, leftOffset, topOffset;

        public ConsoleUI(GameField2D gameField) : base(gameField)
        {
            height = gameField.Height;
            width = gameField.Width;
            leftOffset = gameField.LeftOffset;
            topOffset = gameField.TopOffset;
        }

        public override void DrawGameField()
        {
            throw new NotImplementedException();
        }
    }
}
