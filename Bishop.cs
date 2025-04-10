using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chess
{
    internal class Bishop : Piece
    {
        public Bishop(int row, int col, string color) : base(row, col, color)
        {
            Name = 'B';
        }

        public override List<Move> GenerateMoves(Board board)
        {
            List<Move> moves = new List<Move>();

            int[] directionsX = { -1, -1, 1, 1 };
            int[] directionsY = { -1, 1, -1, 1 };
            for(int i=0; i < directionsX.Length; i++)
            {
                int x = Row;
                int y = Col;

                while (true)
                {
                    x += directionsX[i];
                    y += directionsY[i];

                    if (x < 0 || x >= 8 || y < 0 || y >= 8)
                        break;
                    if (board.Squares[x, y].Piece == null)
                    {
                        Move move = new Move(board.Squares[Row, Col], board.Squares[x, y]);
                        moves.Add(move);
                    }
                    else if (board.Squares[x, y].Piece.Color != Color)
                    {
                        Move move = new Move(board.Squares[Row, Col], board.Squares[x, y]);
                        moves.Add(move);
                        break;
                    }
                    else
                        break;
                }
            }

            return moves;
        }
    }
}
