using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Hashtable hashtable = new Hashtable() { { '(', ')' }, { '{', '}' }, { '[', ']' } };
            Hashtable reversehashtable = new Hashtable() { { ')', '(' }, { '}', '{' }, { ']', '[' } };

            // Return false off the bat if we get a null or an uneven amount of parens or the
            // first parens is a closing paren
            if (string.IsNullOrEmpty(s) || s.Length % 2 != 0 || hashtable.ContainsValue(s[0]))
                return false;

            Stack<char> myStack = new Stack<char>();
            for (var x = 0; x < s.Length; x++)
            {
                // If it is a beginning parens push onto the stack
                if (hashtable.ContainsKey(s[x]))
                    myStack.Push(s[x]);
                // Check if an ending parens
                if (hashtable.ContainsValue(s[x]))
                {
                    // Make sure we have data on the stack to do a match
                    //If we have data peek onto the stack and check if the last value placed 
                    // on the stack matches the current loop value
                    // If we have a match pop it off the stack. If we don't have a match, then
                    // the last opening parens we pushed on the stack does not match the closing parens
                    // we just encountered.
                    if (myStack.Count!= 0 && myStack.Peek() == (char)reversehashtable[s[x]])
                    {
                        // remove a match from the stack
                        myStack.Pop();
                    }
                    else return false;
                }
            }

            // In order to pass all beginning values must be removed from the stack
            return myStack.Count == 0;
        }
    }
}
