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
                    try {

                        Console.Clear();
                        Screen.printGame(newGame);
                        Console.Write("Origem: ");
                        Position origin = Screen.readPosition().toPosition();
                        newGame.validateOrigin(origin);
                        bool[,] possibleMoves = newGame.Board.piece(origin).possibleMoves();
                        Console.Clear();
                        Screen.printBoard(newGame.Board, possibleMoves);
                        Console.WriteLine();
                        Console.Write("Target: ");
                        Position target = Screen.readPosition().toPosition();
                        newGame.validateTarget(origin, target);
                        newGame.makeAMove(origin, target);
                        newGame.passTheTurn();
                    }
                    catch (BoardException e) {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

            }
            catch (BoardException e) {
                Console.WriteLine(e.Message);
            }
        }




    }
}
