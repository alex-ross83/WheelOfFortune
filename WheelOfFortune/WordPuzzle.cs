using System;
using System.Linq;

namespace WheelOfFortune
{
    class WordPuzzle
    {
        private string solution;
        private char[] decomposedSolution;
        public char[] MaskedSolution { get; set; }
        public static void check() { }
        public WordPuzzle(string sol)
        {
            this.solution = sol;
            this.decomposedSolution = sol.ToArray();
            this.MaskedSolution = new char[this.decomposedSolution.Length];
            for (int i = 0; i < this.MaskedSolution.Length; i++)
            {
                this.MaskedSolution[i] = '_';
            }
        }

        public bool isSolved()
        {
            return (new String(this.MaskedSolution)).IndexOf('_') == -1;
        }

        public bool guessCharacter(char c)
        {
            bool result = false;
            for (int i = 0; i < this.decomposedSolution.Length; i++)
            {
                if(this.decomposedSolution[i] == c)
                {
                    this.MaskedSolution[i] = c;
                    result = true;
                }
            }
            return result;
        }

        public bool solve(string s)
        {
            return String.Equals(s, this.solution, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
