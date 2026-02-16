
using Tabuleiro;

namespace Controle {
    internal class Rook : Piece {
        public Rook(Board board, Color color) : base(board, color) {
        }

        public override bool[,] possibleMoves() {
            bool[,] possibleMoves = new bool[board.NumberOfLines, board.NumberOfColumns];
            Position currentPosition = new Position(0, 0);

            //positions starting at up and going clock-wise

            //Up
            currentPosition.setPosition(position.Line - 1, position.Column);
            while (board.validPosition(currentPosition) && validMove(currentPosition)) {
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
                if (board.piece(currentPosition) != null && board.piece(currentPosition).color != this.color)
                    break;
                currentPosition.Line--;
            }
            //Right
            currentPosition.setPosition(position.Line, position.Column + 1);
            while (board.validPosition(currentPosition) && validMove(currentPosition)) {
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
                if (board.piece(currentPosition) != null && board.piece(currentPosition).color != this.color)
                    break;
                currentPosition.Column++;
            }
            //Down
            currentPosition.setPosition(position.Line + 1, position.Column);
            while (board.validPosition(currentPosition) && validMove(currentPosition)) {
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
                if (board.piece(currentPosition) != null && board.piece(currentPosition).color != this.color)
                    break;
                currentPosition.Line++;
            }
            //Left
            currentPosition.setPosition(position.Line, position.Column - 1);
            while (board.validPosition(currentPosition) && validMove(currentPosition)) {
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
                if (board.piece(currentPosition) != null && board.piece(currentPosition).color != this.color)
                    break;
                currentPosition.Column--;
            }

            return possibleMoves;
        }

        private bool validMove(Position position) {
            Piece piece = board.piece(position);
            return piece == null || piece.color != this.color;
        }
        public override string ToString() {
            return "R";
        }
    }
}
