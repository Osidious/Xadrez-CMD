using Controle;
using System.Reflection.PortableExecutable;
using Tabuleiro;

namespace Xadrez_CMD {
    class Program {
        static void Main(string[] args) {
            /*try {
                Board board = new Board(8, 8);
                Screen.setBoard(board);
                Screen.printBoard(board);
            }
            catch (BoardException e) {
                Console.WriteLine(e.Message);
            }*/

            ChessPosition chessNotation = new ChessPosition('a', 8);
            Console.WriteLine(chessNotation);

            Console.WriteLine(chessNotation.toPosition());
            
        }

        
    }
}
