using System;
using StacksAndQueues.Classes;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "([Hello{}( )[]world!])";
            bool result = MultiBracketValidation(str);
            Console.WriteLine($"Does \"{str}\" have balanced brackets? {result}");
        }

        /// <summary>
        /// Takes in a string, breaks the string into a char array, then iterates through it looking for brackets. Opening brackets go to an instanced stack, closing brackets are compared to the top node for a matching open bracket type and then removed from the stack if so, or added to the stack if not. If by the end of the array the stack is empty then all brackets are balanced and returns true, if the stack has remaining nodes then it was imbalanced and returns false.
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>boolean</returns>
        public static bool MultiBracketValidation(string input)
        {
            if (input.Trim() == "") { return false; }  // Empty string has no brackets thus is always false

            Stack validator = new Stack();
            bool hasBrackets = false;

            char[] charString = input.ToCharArray();

            for (int i = 0; i < charString.Length; i++)
            {
                switch (charString[i])
                {
                    case '(':
                        validator.Push(charString[i]);
                        hasBrackets = true;
                        break;
                    case '[':
                        validator.Push(charString[i]);
                        hasBrackets = true;
                        break;
                    case '{':
                        validator.Push(charString[i]);
                        hasBrackets = true;
                        break;
                    case ')':
                        if (i == 0) { return false; }   // If first char is a closing bracket then always false
                        if (validator.Top.Value == '(')
                        {
                            validator.Pop();
                        }
                        else
                        {
                            validator.Push(charString[i]);
                        }
                        hasBrackets = true;
                        break;
                    case ']':
                        if (i == 0) { return false; }
                        if (validator.Top.Value == '[')
                        {
                            validator.Pop();
                        }
                        else
                        {
                            validator.Push(charString[i]);
                        }
                        hasBrackets = true;
                        break;
                    case '}':
                        if (i == 0) { return false; }
                        if (validator.Top.Value == '{')
                        {
                            validator.Pop();
                        }
                        else
                        {
                            validator.Push(charString[i]);
                        }
                        hasBrackets = true;
                        break;
                    default:
                        break;
                }
            }

            if (validator.Top == null && hasBrackets)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
