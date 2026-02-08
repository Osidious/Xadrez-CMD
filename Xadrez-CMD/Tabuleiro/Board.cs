

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
            if (existingPiece(position))
                throw new BoardException("This space is already ocupied in the board");
            Pieces[position.Line, position.Column] = piece;
            piece.position = position;
        }

        public Piece removePiece(Position position) {
            if (piece(position) == null)
                return null;
            Piece selectedPiece = piece(position);
            Pieces[position.Line, position.Column] = null;
            return selectedPiece;
        }
        public Piece piece(int line, int column) {
            return Pieces[line, column];
        }
        public Piece piece(Position position) {
            return Pieces[position.Line, position.Column];
        }
        public bool existingPiece(Position position) {
            validatePosition(position);
            return piece(position) != null;
        }
        public bool validPosition(Position position) {
            if (position.Line < 0 || position.Column < 0 || position.Line > 7 || position.Column > 7)
                return false;
            return true;
        }

        public void validatePosition(Position position) {
            if (!validPosition(position))
                throw new BoardException("Posição Inválida");
        }

    }
}
