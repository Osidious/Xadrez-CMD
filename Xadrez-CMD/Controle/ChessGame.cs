using System;
using System.Net.NetworkInformation;
using Tabuleiro;


namespace Controle {
    internal class ChessGame {
        public Board Board { get; private set; }
        private int turn;
        private Color player;
        public bool GameEnded { get; private set; }

        public ChessGame() {
            Board = new Board(8, 8);
            turn = 1;
            player = Color.White;
            GameEnded = false;
            setBoard();
        }

        public void move(Position origin, Position target) {
            Piece movingPiece = Board.removePiece(origin);
            movingPiece.numberOfMovesIncrement();
            Piece capturedPiece = Board.removePiece(target);
            Board.addPiece(movingPiece, target);
        }

        public void setBoard() {
            // set the white pieces
            Board.addPiece(new Rook(Board, Color.Black), new ChessPosition('a', 8).toPosition());
            Board.addPiece(new Rook(Board, Color.Black), new ChessPosition('h', 8).toPosition());
            Board.addPiece(new Knight(Board, Color.Black), new ChessPosition('b', 8).toPosition());
            Board.addPiece(new Knight(Board, Color.Black), new ChessPosition('g', 8).toPosition());
            Board.addPiece(new Bishop(Board, Color.Black), new ChessPosition('c', 8).toPosition());
            Board.addPiece(new Bishop(Board, Color.Black), new ChessPosition('f', 8).toPosition());
            Board.addPiece(new Queen(Board, Color.Black), new ChessPosition('d', 8).toPosition());
            Board.addPiece(new King(Board, Color.Black), new ChessPosition('e', 8).toPosition());
            //set the black pieces
            Board.addPiece(new Rook(Board, Color.White), new ChessPosition('a', 1).toPosition());
            Board.addPiece(new Rook(Board, Color.White), new ChessPosition('h', 1).toPosition());
            Board.addPiece(new Knight(Board, Color.White), new ChessPosition('b', 1).toPosition());
            Board.addPiece(new Knight(Board, Color.White), new ChessPosition('g', 1).toPosition());
            Board.addPiece(new Bishop(Board, Color.White), new ChessPosition('c', 1).toPosition());
            Board.addPiece(new Bishop(Board, Color.White), new ChessPosition('f', 1).toPosition());
            Board.addPiece(new Queen(Board, Color.White), new ChessPosition('d', 1).toPosition());
            Board.addPiece(new King(Board, Color.White), new ChessPosition('e', 1).toPosition());
            for (int i = 0;i < 8;i++) {
                Board.addPiece(new Pawn(Board, Color.Black), new ChessPosition((char)('a' + i), 7).toPosition());
                Board.addPiece(new Pawn(Board, Color.White), new ChessPosition((char)('a' + i), 2).toPosition());

            }
        }
    }
}
