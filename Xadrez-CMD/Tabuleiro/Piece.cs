namespace Tabuleiro {
    abstract class Piece {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int NumberOfMoves { get; protected set; }
        public Board board { get; set; }

        public Piece(Board board, Color color) {
            this.position = null;
            this.color = color;
            NumberOfMoves = 0;
            this.board = board;
        }

        public abstract bool[,] possibleMoves();

        public void numberOfMovesIncrement() {
            NumberOfMoves++;
        }
        public void numberOfMovesDecrement() {
            NumberOfMoves--;
        }

        public bool validMove() {
            bool[,] validMoves = possibleMoves();
            for (int i = 0;i < board.NumberOfLines;i++) {
                for (int j = 0;j < board.NumberOfColumns;j++) {
                    if (validMoves[i, j] == true)
                        return true;
                }
            }
            return false;
        }

        public bool validMoveAvailiable(Position position) {
            return possibleMoves()[position.Line, position.Column];
        }
    }
}
