using Tabuleiro;

namespace Controle {
    internal class King : Piece {
        public King(Board board, Color color) : base(board, color) {
        }

        public override bool[,] possibleMoves() {
            bool[,] possibleMoves = new bool[board.NumberOfLines, board.NumberOfColumns];
            Position currentPosition = new Position(0, 0);

            //numpad positions starting at 8 and going clock-wise

            //8
            currentPosition.setPosition(position.Line - 1, position.Column);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;

            //9
            currentPosition.setPosition(position.Line - 1, position.Column + 1);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //6
            currentPosition.setPosition(position.Line, position.Column + 1);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //3
            currentPosition.setPosition(position.Line + 1, position.Column + 1);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //2
            currentPosition.setPosition(position.Line + 1, position.Column);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //1
            currentPosition.setPosition(position.Line + 1, position.Column - 1);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //4
            currentPosition.setPosition(position.Line, position.Column - 1);
            if (board.validPosition(currentPosition) && validMove(currentPosition))
                possibleMoves[currentPosition.Line, currentPosition.Column] = true;
            //7
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