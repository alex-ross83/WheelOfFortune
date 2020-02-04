using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = "casa";
            var puzzle = new WordPuzzle(solution);
            Console.WriteLine("Hi, what is your name?");
            string player = Console.ReadLine();
            var gb = new GameBoard(player, puzzle);
            bool playing = true;
            while (playing)
            {
                Console.WriteLine("This is the puzzle:");
                Console.WriteLine(gb.puzzle.MaskedSolution);
                Console.WriteLine("Choose one: (G)uess, (S)olve, (Q)uit");
                string option = Console.ReadLine().ToLower();
                if(option == "g")
                {
                    Console.WriteLine("Choose a letter:");
                    String letter = Console.ReadLine();
                    if (gb.puzzle.guessCharacter(letter[0]))
                    {
                        Console.WriteLine("Good choice!");
                        if (gb.puzzle.isSolved())
                        {
                            Console.WriteLine("You won!!!");
                            playing = false;
                        }
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Sorry! Try again...");
                        continue;
                    }
                }
                if(option == "s")
                {
                    Console.WriteLine("Type your solution:");
                    String s = Console.ReadLine();
                    if (gb.puzzle.solve(s))
                    {
                        Console.WriteLine("You won!!!");
                        playing = false;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Goodbye!!!");
                    playing = false;
                    continue;
                }
            }
            Console.ReadLine();
        }
    }
}
