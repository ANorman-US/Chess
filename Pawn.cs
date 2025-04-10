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
            Name = 'P';
        }

        public override List<Move> GenerateMoves(Board board)
        {
            List<Move> moves = new List<Move>();

            int direction = 1;
            if (Color == "black")
                direction = -1;
            if (Row + direction >= 0 && Row + direction < 8)
            {
                if (board.Squares[Row + direction, Col].Piece == null)
                {
                    Move move = new Move(board.Squares[Row, Col], board.Squares[Row + direction, Col]);
                    moves.Add(move);
                }
            }

            if ((Color == "white" && Row == 1) || (Color == "black" && Row == 6))
            {
                if (board.Squares[Row + 2 * direction, Col].Piece == null && board.Squares[Row + direction, Col].Piece == null)
                {
                    Move move = new Move(board.Squares[Row, Col], board.Squares[Row + 2 * direction, Col]);
                    moves.Add(move);
                }
            }

            for (int i = -1; i <= 1; i += 2)
            {
                if (Col + i >= 0 && Col + i < 8)
                {
                    if (board.Squares[Row + direction, Col + i].Piece != null && board.Squares[Row + direction, Col + i].Piece.Color != Color)
                    {
                        Move move = new Move(board.Squares[Row, Col], board.Squares[Row + direction, Col + i]);
                        moves.Add(move);
                    }
                }
            }

            return moves;
        }

    }
}
