using System;
using System.Collections.Generic;

namespace Pushdown.ProblemSolver
{
    public class BalancedSymbols
    {
        private Stack<char> _stack = new Stack<char>();

        // sigma = { '(', ')', '[', ']', '{', '}' }
        private readonly Dictionary<char, char> _symbolPairs = new Dictionary<char, char>
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

        public bool Check(string input)
        {
            foreach (var c in input)
            {
                // If the character is an opening symbol and it is in the dictionary, push it onto the stack.
                if (_symbolPairs.ContainsKey(c))
                    _stack.Push(c); 

                // If the character is a closing symbol and it is in the dictionary, pop the stack and compare the popped value to the closing symbol.
                else if (_symbolPairs.ContainsValue(c))
                {
                    if (_stack.Count == 0)
                        return false;

                    var top = _stack.Pop();
                    // check the value of the key top if it matches the value of c
                    if (_symbolPairs[top] != c) 
                    {
                        return false;
                    }
                }
            }
            
            // If the stack is empty, the symbols are balanced.
            return _stack.Count == 0;
        }
    }
}