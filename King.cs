using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chess
{
    internal class King : Piece
    {
        public King(int row, int col, string color) : base(row, col, color)
        {
            Name = 'K';
        }

        public override List<Move> GenerateMoves(Board board)
        {
            List<Move> moves = new List<Move>();

            int[] directionsX = { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] directionsY = { -1, 0, 1, 1, 1, 0, -1, -1 };

            for (int i = 0; i < directionsX.Length; i++)
            {
                int newX = Row + directionsX[i];
                int newY = Col + directionsY[i];

                if (newX >= 0 && newX < 8 && newY >= 0 && newY < 8)
                {
                    if (board.Squares[newX, newY].Piece == null || board.Squares[newX, newY].Piece.Color != this.Color)
                    {
                        Move move = new Move(board.Squares[Row, Col], board.Squares[newX, newY]);
                        moves.Add(move);
                    }
                }
            }
            return moves;
        }
    }
}
