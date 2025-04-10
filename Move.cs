using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Move
    {
        public Square Origin { get; private set; }
        public Square Destination { get; private set; }
        public Piece Piece { get; private set; }
        public Piece CapturePiece { get; private set; }

        public Move(Square origin, Square Destination)
        {
            Origin = origin;
            Destination = Destination;
        }
        public Move(Square origin, Square destination, Piece piece)
        {
            Origin = origin;
            Destination = destination;
            Piece = piece;
        }
        public Move(Square origin, Square destination, Piece piece, Piece capturePiece)
        {
            Origin = origin;
            Destination = destination;
            Piece = piece;
            CapturePiece = capturePiece;
        }
    }
}
