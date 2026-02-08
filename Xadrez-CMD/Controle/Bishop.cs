using Tabuleiro;

namespace Controle {
    internal class Bishop : Piece{
        public Bishop(Board board, Color color) : base(board, color) {
        }

        public override bool[,] possibleMoves() {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return "B";
        }
    }
}
