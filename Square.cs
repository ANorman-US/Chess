using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Square
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public string Color { get; private set; }
        public Piece Piece { get; set; }
        public Square(int row, int col)
        {
            Row = row;
            Col = col;
            Piece = null;
            AssignColor();
        }

        public void AssignPieceToSquare(Piece piece)
        {
            Piece = piece;
        }

        public bool IsSquareOccupied()
        {
            if (Piece != null)
                return true;
            return false;
        }

        public string StringLocation()
        {
            char file = (char)('a' + Col);
            int rank = Row+1;
            return $"{file}{rank}";
        }
        private void AssignColor()
        {
            if ((Row+Col) %2 == 0)
            {
                Color = "light";
            }
            Color = "dark";
        }

    }
}
