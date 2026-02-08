

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
                    printPiece(board.piece(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("   a  b  c  d  e  f  g  h");
            Console.ResetColor();
        }

        public static void printBoard(Board board, bool[,] possibleMoves) {
            ConsoleColor defaultBackground = Console.BackgroundColor;
            ConsoleColor alteredBackground = ConsoleColor.Gray;
            for (int i = 0;i < board.NumberOfLines;i++) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(8 - i + " ");
                Console.ResetColor();
                for (int j = 0;j < board.NumberOfColumns;j++) {
                    if (possibleMoves[i, j] == true)
                        Console.BackgroundColor = alteredBackground;
                    else
                        Console.BackgroundColor = defaultBackground;
                    printPiece(board.piece(i, j));
                }
                Console.WriteLine();
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("   a  b  c  d  e  f  g  h");
            Console.ResetColor();
        }

        public static void printPiece(Piece piece) {
            if (piece == null)
                Console.Write(" - ");
            else {
                if (piece.color == Color.White)
                    Console.Write($" {piece} ");
                else {
                    ConsoleColor defaultColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($" {piece} ");
                    Console.ResetColor();
                }
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
