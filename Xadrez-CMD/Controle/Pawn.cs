using Tabuleiro;

namespace Controle {
    internal class Pawn : Piece{
        public Pawn(Board board, Color color) : base(color, board) {
        }

        public override string ToString() {
            return "P";
        }
    }
}
