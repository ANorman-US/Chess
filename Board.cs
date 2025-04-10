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

        public void InsertPiece(Piece piece)
        {
            Squares[piece.Row,piece.Col].AssignPieceToSquare(piece);
        }
        public void InitializeBoard()
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
