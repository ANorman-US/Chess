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

        public Player(string color)
        {
            Color = color;

        }

        public void AddPiece(Piece piece)
        {
            Pieces.Add(piece);
        }
    }
}
