using Tabuleiro;

namespace Controle {
    internal class Knight : Piece {
        public Knight(Board board, Color color) : base(board, color) {
        }

        public override bool[,] possibleMoves() {
            bool[,] possibleMoves = new bool[board.NumberOfLines, board.NumberOfColumns];
            Position currentPosition = new Position(0, 0);

            //positions starting at Up-Right and going clock-wise

            //Up-Right
            currentPosition.setPosition(position.Line - 2, position.Column + 1);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;

            //Right-Up
            currentPosition.setPosition(position.Line - 1, position.Column + 2);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //Right-Down
            currentPosition.setPosition(position.Line + 1, position.Column + 2);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //Down-Right
            currentPosition.setPosition(position.Line + 2, position.Column + 1);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //Down-Left
            currentPosition.setPosition(position.Line + 2, position.Column - 1);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //Left-Down
            currentPosition.setPosition(position.Line + 1, position.Column - 2);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //Left-Up
            currentPosition.setPosition(position.Line - 1, position.Column - 2);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //Up-Left
            currentPosition.setPosition(position.Line - 2, position.Column - 1);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;

            return possibleMoves;
        }

        private bool validMove(Position position) {
            Piece piece = board.piece(position);
            return piece == null || piece.color != this.color;
        }

        public override string ToString() {
            return "N";
        }
    }
}
