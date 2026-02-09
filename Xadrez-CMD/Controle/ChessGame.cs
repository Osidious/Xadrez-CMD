using System;
using System.Net.NetworkInformation;
using Tabuleiro;


namespace Controle {
    internal class ChessGame {
        public Board Board { get; private set; }
        public int turn { get; private set; }
        public Color currentPlayer { get; private set; }
        public bool GameEnded { get; private set; }
        private HashSet<Piece> pieces;
        private HashSet<Piece> capturedPieces;
        public ChessGame() {
            Board = new Board(8, 8);
            turn = 1;
            currentPlayer = Color.White;
            GameEnded = false;
            pieces = new HashSet<Piece>();
            capturedPieces = new HashSet<Piece>();
            setBoard();
        }
        public void move(Position origin, Position target) {
            Piece movingPiece = Board.removePiece(origin);
            movingPiece.numberOfMovesIncrement();
            Piece capturedPiece = Board.removePiece(target);
            Board.addPiece(movingPiece, target);
            if (capturedPiece != null)
                capturedPieces.Add(capturedPiece);
        }

        public void makeAMove(Position origin, Position target) {
            move(origin, target);
            turn++;
        }

        public HashSet<Piece> piecesCaptured(Color color) {
            HashSet<Piece> sortedCaptures = new HashSet<Piece>();
            foreach (Piece selectedPiece in capturedPieces) {
                if (selectedPiece.color == color)
                    sortedCaptures.Add(selectedPiece);
            }
            return sortedCaptures;

        }

        public HashSet<Piece> piecesInPlay(Color color) {
            HashSet<Piece> inPlay = new HashSet<Piece>();
            foreach (Piece selectedPiece in pieces) {
                if (selectedPiece.color == color)
                    inPlay.Add(selectedPiece);
            }
            inPlay.ExceptWith(piecesCaptured(color));
            return inPlay;
        }
        public void passTheTurn() {
            if (currentPlayer == Color.White)
                currentPlayer = Color.Black;
            else
                currentPlayer = Color.White;
        }

        public void validateOrigin(Position origin) {
            if (Board.piece(origin) == null)
                throw new BoardException("No piece occupies the position selected!");
            if (currentPlayer != Board.piece(origin).color)
                throw new BoardException("The piece you selected does not belong to you!");
            if (Board.piece(origin).validMove() == false)
                throw new BoardException("The piece you selected does not posses any valid moves!");

        }
        public void validateTarget(Position origin, Position Target) {
            if (Board.piece(origin).validMoveAvailiable(Target) != true)
                throw new BoardException("Target position Invalid!");
        }

        public void addNewPiece(char column, int line, Piece piece) {
            Board.addPiece(piece, new ChessPosition(column, line).toPosition());
            pieces.Add(piece);
        }
        public void setBoard() {
            // set the Black pieces
            addNewPiece('a', 8, new Rook(Board, Color.Black));
            addNewPiece('h', 8, new Rook(Board, Color.Black));
            addNewPiece('b', 8, new Knight(Board, Color.Black));
            addNewPiece('g', 8, new Knight(Board, Color.Black));
            addNewPiece('c', 8, new Bishop(Board, Color.Black));
            addNewPiece('f', 8, new Bishop(Board, Color.Black));
            addNewPiece('d', 8, new Queen(Board, Color.Black));
            addNewPiece('e', 8, new King(Board, Color.Black));
            //  set the White Pieces
            addNewPiece('a', 1, new Rook(Board, Color.White));
            addNewPiece('h', 1, new Rook(Board, Color.White));
            addNewPiece('b', 1, new Knight(Board, Color.White));
            addNewPiece('g', 1, new Knight(Board, Color.White));
            addNewPiece('c', 1, new Bishop(Board, Color.White));
            addNewPiece('f', 1, new Bishop(Board, Color.White));
            addNewPiece('d', 1, new Queen(Board, Color.White));
            addNewPiece('e', 1, new King(Board, Color.White));
            for (int i = 0;i < 8;i++) {
                addNewPiece((char)('a' + i), 7, new Pawn(Board, Color.Black));
                addNewPiece((char)('a' + i), 2, new Pawn(Board, Color.White));

            }
        }
    }
}
