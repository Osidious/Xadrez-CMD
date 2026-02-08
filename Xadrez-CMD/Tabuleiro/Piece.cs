namespace Tabuleiro {
    class Piece {
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

        


    }
}
