using Controle;
using System.Reflection.PortableExecutable;
using System.Threading.Channels;
using Tabuleiro;

namespace Xadrez_CMD {
    class Program {
        static void Main(string[] args) {
            try {
                ChessGame newGame = new ChessGame();

                while (!newGame.GameEnded) {
                    Console.Clear();
                    Screen.printBoard(newGame.Board);
                    Console.WriteLine();
                    Console.WriteLine("Origem: ");
                    Position origin = Screen.readPosition().toPosition();
                    Console.WriteLine("Target: ");
                    Position target = Screen.readPosition().toPosition();
                    newGame.move(origin, target);   
                }
            }
            catch (BoardException e) {
                Console.WriteLine(e.Message);
            }
        }

        

        
    }
}
