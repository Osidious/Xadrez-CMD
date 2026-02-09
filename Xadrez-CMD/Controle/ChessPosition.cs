using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Controle {
    internal class ChessPosition {
        public char Column { get; set; }
        public int Line { get; set; }

        public ChessPosition(char column, int line) {
            Line = line;
            Column = column;
        }

        public Position toPosition() {
            return new Position(8 - Line,Column - 'a');
        }

        public override string ToString() {
            return $"{Line}{Column}";
        }
    }
}
