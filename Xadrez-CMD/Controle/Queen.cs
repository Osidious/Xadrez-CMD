using Tabuleiro;

namespace Controle {
    internal class Queen : Piece{
        public Queen(Board board, Color color) : base(board, color) {
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
            return "Q";
        }
    }
}
