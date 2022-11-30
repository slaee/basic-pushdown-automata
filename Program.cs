/**
 * [Pushdown automaton Program]
 * Balanced symbols and Palindrome
 *
 * Author: Sly Kint Bacalso
 * Date: 11-28-2022
 */

using Pushdown.ProblemSolver;

namespace Pushdown
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            do {
                Console.WriteLine("\n\nPushdown Automata\n[1] Balanced Symbols\n[2] Palindrome\n[3] Exit\n");
                Console.Write("Enter option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        BalancedSymbols bs = new BalancedSymbols();
                        Console.Write("Enter string: ");
                        string input = Console.ReadLine();
                        
                        if (bs.Check(input))
                        {
                            Console.WriteLine("ACCEPTED");
                        }
                        else
                        {
                            Console.WriteLine("NOT ACCEPTED");
                        }
                        break;
                    case 2:
                        Palindrome p = new Palindrome();
                        Console.Write("Enter string: ");
                        string input2 = Console.ReadLine();
                        
                        if (p.Check(input2))
                        {
                            Console.WriteLine("ACCEPTED");
                        }
                        else
                        {
                            Console.WriteLine("NOT ACCEPTED");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            } while (option != 3);
        }
    }
}