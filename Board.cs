using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Board
    {
        public Square[,] Squares {  get; set; }

        public Board()
        {
            Squares = new Square[8, 8];
            InitializeBoard();
        }

        public bool IsValidMove(Piece piece, Move move)
        {
            return false;
        }

        public void InsertPiece(Piece piece)
        {
            Squares[piece.Row,piece.Col].AssignPieceToSquare(piece);
        }

        public void PrintBoard()
        {
            for(int row = 7; row >= 0; row--)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (Squares[row, col].Piece != null)
                        Console.Write(Squares[row, col].Piece.Name);
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
        private void InitializeBoard()
        {
            for(int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Squares[row,col] = new Square(row,col);
                }
            }
        }
    }
}
