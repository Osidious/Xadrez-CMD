using Tabuleiro;

namespace Controle {
    internal class Knight : Piece{
        public Knight(Board board, Color color) : base(color, board) {
        }

        public override string ToString() {
            return "N";
        }
    }
}
