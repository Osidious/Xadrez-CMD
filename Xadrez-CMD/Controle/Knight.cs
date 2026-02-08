using Tabuleiro;

namespace Controle {
    internal class Knight : Piece{
        public Knight(Board board, Color color) : base(board, color) {
        }

        public override bool[,] possibleMoves() {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return "N";
        }
    }
}
