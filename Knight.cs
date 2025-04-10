using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chess
{
    internal class Knight : Piece
    {
        public Knight(int row, int col, string color) : base(row, col, color)
        {
            Name = 'N';
        }

        public override List<Move> GenerateMoves(Board board)
        {
            List<Move> moves = new List<Move>();
            int[,] knightMovement = new int[,]
            {
                { -2, -1 }, { -2, 1 }, { 2, -1 }, { 2, 1 },
                { -1, -2 }, { 1, -2 }, { -1, 2 }, { 1, 2 }
            };
            for (int i = 0; i < knightMovement.GetLength(0); i++)
            {
                int newRow = Row + knightMovement[i, 0];
                int newCol = Col + knightMovement[i, 1];

                if (newRow >= 0  && newRow <8 && newCol >= 0 && newCol < 8)//in bounds
                {
                    //no piece or enemy piece
                    if (board.Squares[newRow, newCol].Piece == null || board.Squares[newRow, newCol].Piece.Color != this.Color)
                    {
                        Move move = new Move(board.Squares[Row, Col], board.Squares[newRow, newCol]);
                        moves.Add(move);
                    }
                }
            }

            return moves;
        }


    }
}
