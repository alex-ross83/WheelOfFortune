namespace WheelOfFortune
{
    class GameBoard
    {
        public string Player { get; set; }
        public WordPuzzle puzzle { get; private set; }

        public GameBoard(string playerName, WordPuzzle p) {
            this.puzzle = p;
            this.Player = playerName;
        }
    }
}
