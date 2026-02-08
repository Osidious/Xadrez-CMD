

using Controle;
using Tabuleiro;

namespace Xadrez_CMD {
    class Screen {
        public static void printBoard(Board board) {
            for(int i = 0; i < board.NumberOfLines;i++) {
                for(int j = 0; j < board.NumberOfColumns;j++) {
                    if(board.piece(i, j) == null)
                        Console.Write(" - ");
                    else
                        Console.Write($" {board.piece(i, j)} ");
                }
                Console.WriteLine();
            }
        }

        public static void setBoard(Board board) {
            // set the white pieces
            board.addPiece(new Rook(board, Color.Black), new Position(0, 0));
            board.addPiece(new Rook(board, Color.Black), new Position(0, 7));
            board.addPiece(new Knight(board, Color.Black), new Position(0, 1));
            board.addPiece(new Knight(board, Color.Black), new Position(0, 6));
            board.addPiece(new Bishop(board, Color.Black), new Position(0, 2));
            board.addPiece(new Bishop(board, Color.Black), new Position(0, 5));
            board.addPiece(new Queen(board, Color.Black), new Position(0, 3));
            board.addPiece(new King(board, Color.Black), new Position(0, 4));
            //set the black pieces
            board.addPiece(new Rook(board, Color.White), new Position(7, 7));
            board.addPiece(new Rook(board, Color.White), new Position(7, 0));
            board.addPiece(new Knight(board, Color.White), new Position(7, 1));
            board.addPiece(new Knight(board, Color.White), new Position(7, 6));
            board.addPiece(new Bishop(board, Color.White), new Position(7, 2));
            board.addPiece(new Bishop(board, Color.White), new Position(7, 5));
            board.addPiece(new Queen(board, Color.White), new Position(7, 3));
            board.addPiece(new King(board, Color.White), new Position(7, 4));
            for (int i = 0;i < 8;i++) {
                board.addPiece(new Pawn(board, Color.Black), new Position(1, i));
                board.addPiece(new Pawn(board, Color.White), new Position(6, i));

            }
        }
    }
}
