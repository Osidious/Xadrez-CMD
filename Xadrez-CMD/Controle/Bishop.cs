using Tabuleiro;

namespace Controle {
    internal class Bishop : Piece {
        public Bishop(Board board, Color color) : base(board, color) {
        }

        public override bool[,] possibleMoves() {
            bool[,] possibleMoves = new bool[board.NumberOfLines, board.NumberOfColumns];
            Position currentPosition = new Position(0, 0);

            //positions starting at up right and going clock-wise
            //up right

            currentPosition.setPosition(position.Line - 1, position.Column + 1);
            while (board.validPosition(currentPosition) && validMove(currentPosition)) {
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
                if (board.piece(currentPosition) != null && board.piece(currentPosition).color != color)
                    break;
                currentPosition.setPosition(currentPosition.Line - 1, currentPosition.Column + 1);
            }

            //down right
            currentPosition.setPosition(position.Line + 1, position.Column + 1);
            while (board.validPosition(currentPosition) && validMove(currentPosition)) {
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
                if (board.piece(currentPosition) != null && board.piece(currentPosition).color != color)
                    break;
                currentPosition.setPosition(currentPosition.Line + 1, currentPosition.Column + 1);
            }

            //down left
            currentPosition.setPosition(position.Line + 1, position.Column - 1);
            while (board.validPosition(currentPosition) && validMove(currentPosition)) {
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
                if (board.piece(currentPosition) != null && board.piece(currentPosition).color != color)
                    break;
                currentPosition.setPosition(currentPosition.Line + 1, currentPosition.Column - 1);
            }

            //up left
            currentPosition.setPosition(position.Line - 1, position.Column - 1);
            while (board.validPosition(currentPosition) && validMove(currentPosition)) {
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
                if (board.piece(currentPosition) != null && board.piece(currentPosition).color != color)
                    break;
                currentPosition.setPosition(currentPosition.Line - 1, currentPosition.Column - 1);
            }
            return possibleMoves;
        }

        private bool validMove(Position position) {
            Piece piece = board.piece(position);
            return piece == null || piece.color != this.color;
        }

        public override string ToString() {
            return "B";
        }
    }
}
