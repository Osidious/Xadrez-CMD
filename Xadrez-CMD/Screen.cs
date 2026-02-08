

using Controle;
using Tabuleiro;

namespace Xadrez_CMD {
    class Screen {
        public static void printBoard(Board board) {
            for (int i = 0;i < board.NumberOfLines;i++) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(8 - i + " ");
                Console.ResetColor();
                for (int j = 0;j < board.NumberOfColumns;j++) {
                    if (board.piece(i, j) == null)
                        Console.Write(" - ");
                    else
                        printPiece(board.piece(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("   a  b  c  d  e  f  g  h");
            Console.ResetColor();
        }

        public static void printPiece(Piece piece) {
            if (piece.color == Color.White)
                Console.Write($" {piece} ");
            else {
                ConsoleColor defaultColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($" {piece} ");
                Console.ResetColor();

            }
        }

        public static ChessPosition readPosition() {
            string position = Console.ReadLine();
            char column = position[0];
            int line = int.Parse(position[1].ToString());
            return new ChessPosition(column, line);
        }
    }
}
