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
            WhitePlayer = new Player("white");
            BlackPlayer = new Player("black");
            InitializePieces();
        }
        public void PlayGame()
        {
            //whitePlayer.TakeTurn();
            //check gameover
            //blackPlayer.TakeTurn();
            //check gameover
        }
        private void InitializePieces()
        {
            /*
             * Piece p = new Rook();
             * whitePlayer.addPiece(p);
             * board.insertPiece(p);
             * etc
             */
            InitPawns();
            
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
