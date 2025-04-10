using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Game
    {
        public int TurnNumber { get; set; }
        public Board Board { get; set; }
        public Player WhitePlayer { get; set; }
        public Player BlackPlayer { get; set; }
        private Piece _whiteKing;
        private Piece _blackKing;

        public Game()
        {
            Board = new Board();
            WhitePlayer = new Player("white", Board);
            BlackPlayer = new Player("black", Board);
            InitializePieces();
            
            //Board.PrintBoard();
        }
        public void PlayGame()
        {
            WhitePlayer.TakeTurn();
            //IsGameOver();
            BlackPlayer.TakeTurn();
            //check gameover
        }

        private bool IsGameOver()
        {
            return false;
        }
        private void InitializePieces()
        {
            InitPawns();
            InitRooks();
            InitKnights();
            InitBishops();
            InitRoyals();
        }
        private void InitRoyals()
        {
            Piece king = new King(0, 4, "white");
            Board.InsertPiece(king);
            WhitePlayer.AddPiece(king);
            _whiteKing = king;

            king = new King(7, 3, "black");
            Board.InsertPiece(king);
            BlackPlayer.AddPiece(king);
            _blackKing = king;

            Piece queen = new Queen(0, 3, "white");
            Board.InsertPiece(queen);
            WhitePlayer.AddPiece(queen);

            queen = new Queen(7, 4, "black");
            Board.InsertPiece(queen);
            BlackPlayer.AddPiece(queen);
        }
        private void InitBishops()
        {
            Piece bishop = new Bishop(0, 2, "white");
            Board.InsertPiece(bishop);
            WhitePlayer.AddPiece(bishop);

            bishop = new Bishop(0, 5, "white");
            Board.InsertPiece(bishop);
            WhitePlayer.AddPiece(bishop);

            bishop = new Bishop(7, 2, "black");
            Board.InsertPiece(bishop);
            BlackPlayer.AddPiece(bishop);

            bishop = new Bishop(7, 5, "black");
            Board.InsertPiece(bishop);
            BlackPlayer.AddPiece(bishop);
        }
        private void InitKnights()
        {
            Piece knight = new Knight(0, 1, "white");
            Board.InsertPiece(knight);
            WhitePlayer.AddPiece(knight);

            knight = new Knight(0, 6, "white");
            Board.InsertPiece(knight);
            WhitePlayer.AddPiece(knight);

            knight = new Knight(7, 1, "black");
            Board.InsertPiece(knight);
            BlackPlayer.AddPiece(knight);

            knight = new Knight(7, 6, "black");
            Board.InsertPiece(knight);
            BlackPlayer.AddPiece(knight);
        }   

        private void InitRooks()
        {
            Piece rook = new Rook(0, 0, "white");
            Board.InsertPiece(rook);
            WhitePlayer.AddPiece(rook);

            rook = new Rook(0, 7, "white");
            Board.InsertPiece(rook);
            WhitePlayer.AddPiece(rook);

            rook = new Rook(7, 0, "black");
            Board.InsertPiece(rook);
            BlackPlayer.AddPiece(rook);

            rook = new Rook(7, 7, "black");
            Board.InsertPiece(rook);
            BlackPlayer.AddPiece(rook);
        }
        private void InitPawns()
        {
            for(int col = 0; col < 8; col++)
            {
                Piece pawn = new Pawn(1, col, "white");
                Board.InsertPiece(pawn);
                WhitePlayer.AddPiece(pawn);
            }
            for (int col = 0; col < 8; col++)
            {
                Piece pawn = new Pawn(6, col, "black");
                Board.InsertPiece(pawn);
                BlackPlayer.AddPiece(pawn);
            }
        }

    }
}
