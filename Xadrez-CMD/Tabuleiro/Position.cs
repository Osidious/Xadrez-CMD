namespace Tabuleiro {
    class Position {
        public int Line { get; set; }
        public int Column { get; set; }

        public Position(int Line, int Column) {
            this.Line = Line;
            this.Column = Column;
        }
        public void setPosition(int Line, int Column) {
            this.Line = Line;
            this.Column = Column;
        }
        public override string ToString() {
            return $"{Line}, {Column}";
        }

    }
}
