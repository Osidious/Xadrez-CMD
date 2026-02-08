

using System.ComponentModel.DataAnnotations.Schema;

namespace Tabuleiro {
    class Board {
        public int NumberOfLines { get; set; }
        public int NumberOfColumns { get; set; }
        public Piece[,] Pieces;

        public Board(int numberOfLines, int numberOfColumns) {
            NumberOfLines = numberOfLines;
            NumberOfColumns = numberOfColumns;
            Pieces = new Piece[NumberOfLines, NumberOfColumns];

        }

        public void addPiece(Piece piece, Position position) {
            Pieces[position.Line, position.Column] = piece;
            piece.position = position;
        }
        public Piece piece(int line, int column) {
            return Pieces[line, column];
        }
    }
}
