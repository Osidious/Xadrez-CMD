using Tabuleiro;

namespace Controle {
    internal class Pawn : Piece {

        public Pawn(Board board, Color color) : base(board, color) {
        }

        public override bool[,] possibleMoves() {
            bool[,] possibleMoves = new bool[board.NumberOfLines, board.NumberOfColumns];
            Position currentPosition = new Position(0, 0);
            if (color == Color.White) {
                // 1 square forward
                currentPosition.setPosition(position.Line - 1, position.Column);
                if (board.validPosition(currentPosition) && board.piece(currentPosition) == null) {
                    possibleMoves[currentPosition.Line, currentPosition.Column] = true;
                }

                // 2 squares forward (first move only)
                currentPosition.setPosition(position.Line - 2, position.Column);
                Position pos2 = new Position(position.Line - 1, position.Column);

                if (board.validPosition(currentPosition) &&
                    board.piece(currentPosition) == null &&
                    board.piece(pos2) == null &&
                    NumberOfMoves == 0) {

                    possibleMoves[currentPosition.Line, currentPosition.Column] = true;
                }
            }
            else {
                // 1 square forward (black moves down the board)
                currentPosition.setPosition(position.Line + 1, position.Column);
                if (board.validPosition(currentPosition) && board.piece(currentPosition) == null) {
                    possibleMoves[currentPosition.Line, currentPosition.Column] = true;
                }

                // 2 squares forward (first move only)
                currentPosition.setPosition(position.Line + 2, position.Column);
                Position pos2 = new Position(position.Line + 1, position.Column);

                if (board.validPosition(currentPosition) &&
                    board.piece(currentPosition) == null &&
                    board.piece(pos2) == null &&
                    NumberOfMoves == 0) {

                    possibleMoves[currentPosition.Line, currentPosition.Column] = true;
                }
                //black pawn logic
            }

            return possibleMoves;
        }

        public override string ToString() {
            return "P";
        }
    }
}
