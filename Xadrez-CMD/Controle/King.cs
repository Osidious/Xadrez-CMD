using Tabuleiro;

namespace Controle {
    internal class King : Piece {
        public King(Board board, Color color) : base(board, color) {
        }

        public override bool[,] possibleMoves() {
            bool[,] possibleMoves = new bool[board.NumberOfLines, board.NumberOfColumns];
            Position currentPosition = new Position(0, 0);

            //positions starting at up and going clock-wise

            //Up
            currentPosition.setPosition(position.Line - 1, position.Column);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;

            //up right
            currentPosition.setPosition(position.Line - 1, position.Column + 1);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //right
            currentPosition.setPosition(position.Line, position.Column + 1);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //down right
            currentPosition.setPosition(position.Line + 1, position.Column + 1);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //down
            currentPosition.setPosition(position.Line + 1, position.Column);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //down left
            currentPosition.setPosition(position.Line + 1, position.Column - 1);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //left
            currentPosition.setPosition(position.Line, position.Column - 1);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //up left
            currentPosition.setPosition(position.Line - 1, position.Column - 1);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;


            return possibleMoves;
        }

        private bool validMove(Position position) {
            Piece piece = board.piece(position);
            return piece == null || piece.color != this.color;
        }
        public override string ToString() {
            return "K";
        }
    }
}