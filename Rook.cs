using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chess
{
    internal class Rook : Piece
    {
        public Rook(int row, int col, string color) : base(row, col, color)
        {
            Name = 'R';
        }

        public override List<Move> GenerateMoves(Board board)
        {
            List<Move> moves = new List<Move>();

            int[] rowDirection = { -1, 1, 0, 0 };
            int[] colDirection = { 0, 0, -1, 1 };
            for(int i=0; i < rowDirection.Length; i++)
            {
                int row = Row;
                int col = Col;

                while (true)
                {
                    row += rowDirection[i];
                    col += colDirection[i];

                    if (row < 0 || row >= 8 || col < 0 || col >= 8)
                        break;

                    if (board.Squares[row, col].Piece == null)//empty square
                    {
                        Move move = new Move(board.Squares[Row, Col], board.Squares[row, col]);
                        moves.Add(move);
                    }
                    else if (board.Squares[row, col].Piece.Color != Color)//enemy piece
                    {
                        Move move = new Move(board.Squares[Row, Col], board.Squares[row, col]);
                        moves.Add(move);
                        break;
                    }
                    else//cant capture own piece
                        break;
                }
            }

            return moves;
        }
    }
}
