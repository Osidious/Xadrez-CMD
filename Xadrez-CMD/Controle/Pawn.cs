using Tabuleiro;

namespace Controle {
    internal class Pawn : Piece{
        public Pawn(Board board, Color color) : base(board, color) {
        }

        public override bool[,] possibleMoves() {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return "P";
        }
    }
}
