using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal abstract class Piece
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public string Color { get; set; }
        public char Name {  get; set; }
        public Piece(int row, int col, string color)
        {
            Row = row;
            Col = col;
            Color = color;
        }

        public abstract List<Move> PossibleMoves();


    }
}
