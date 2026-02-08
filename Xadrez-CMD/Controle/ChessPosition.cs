using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Controle {
    internal class ChessPosition {
        public char Line { get; set; }
        public int Column { get; set; }

        public ChessPosition(char line, int column) {
            Line = line;
            Column = column;
        }

        public Position toPosition() {
            return new Position(8 - Column,Line - 'a');
        }

        public override string ToString() {
            return $"{Line}{Column}";
        }
    }
}
