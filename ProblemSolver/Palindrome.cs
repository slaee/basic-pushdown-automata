using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pushdown.ProblemSolver
{
    public class Palindrome
    {
        private Stack<char> _stack = new Stack<char>();
        public bool Check(string input)
        {
            // push all characters onto the stack
            // S -> a
            // S -> b
            foreach (var c in input)
            {
                _stack.Push(c);
            }

            // pop each character off the stack and compare to the input
            // S -> a S a
            // S -> b S b
            foreach (var c in input)
            {
                if (_stack.Pop() != c)
                {
                    return false;
                }
            }
            return true;
        }
    }
}