using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Pawn : Piece
    {
        public Pawn(int row, int col, string color) : base(row, col, color)
        {
            Name = 'p';
        }

        public override List<Move> PossibleMoves()
        {
            List<Move> moves = new List<Move>();

            return moves;
        }

    }
}
