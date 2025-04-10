using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Player
    {
        public List<Piece> Pieces {  get; set; }
        public string Color { get; private set; }
        public Board Board { get; set; }

        public Player(string color, Board b)
        {
            Color = color;
            Board = b;
            Pieces = new List<Piece>();
        }

        public void TakeTurn()
        {
            //user input
            //get user move
            //check if format correct
            List<Move> validMoves = GenerateValidMoves();
            //check if list contains


            
        }

        private List<Move> GenerateValidMoves()
        {
            List<Move> validMoves = new List<Move>();
            foreach (Piece piece in Pieces)
            {
                List<Move> possibleMoves = piece.GenerateMoves(Board);
                foreach (Move move in possibleMoves)
                {
                    if (Board.IsValidMove(piece, move))
                    {
                        validMoves.Add(move);
                    }
                }
            }
            return validMoves;
        }

        public void AddPiece(Piece piece)
        {
            Pieces.Add(piece);
        }
    }
}
