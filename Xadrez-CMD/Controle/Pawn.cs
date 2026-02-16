using Tabuleiro;

namespace Controle {
    internal class Pawn : Piece {

        public Pawn(Board board, Color color) : base(board, color) {
        }

        public override bool[,] possibleMoves() {
            bool[,] possibleMoves = new bool[board.NumberOfLines, board.NumberOfColumns];

            int direction = (color == Color.White) ? -1 : 1; // white up (-1), black down (+1)

            Position oneAhead = new Position(0, 0);
            Position twoAhead = new Position(0, 0);
            Position diag = new Position(0, 0);

            // 1 square forward
            oneAhead.setPosition(position.Line + direction, position.Column);
            if (board.validPosition(oneAhead) && board.piece(oneAhead) == null) {
                possibleMoves[oneAhead.Line, oneAhead.Column] = true;

                // 2 squares forward (first move only) - only if 1 ahead is empty
                twoAhead.setPosition(position.Line + 2 * direction, position.Column);
                if (NumberOfMoves == 0 && board.validPosition(twoAhead) && board.piece(twoAhead) == null) {
                    possibleMoves[twoAhead.Line, twoAhead.Column] = true;
                }
            }

            // diagonal left capture
            diag.setPosition(position.Line + direction, position.Column - 1);
            if (board.validPosition(diag)) {
                Piece p = board.piece(diag);
                if (p != null && p.color != color) {
                    possibleMoves[diag.Line, diag.Column] = true;
                }
            }

            // diagonal right capture
            diag.setPosition(position.Line + direction, position.Column + 1);
            if (board.validPosition(diag)) {
                Piece p = board.piece(diag);
                if (p != null && p.color != color) {
                    possibleMoves[diag.Line, diag.Column] = true;
                }
            }

            return possibleMoves;
        
        }



        public override string ToString() {
            return "P";
        }
    }
}
