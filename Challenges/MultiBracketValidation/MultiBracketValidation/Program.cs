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

        public static bool MultiBracketValidation(string input)
        {
            Stack validator = new Stack();

            char[] charString = input.ToCharArray();

            for (int i = 0; i < charString.Length; i++)
            {
                switch (charString[i])
                {
                    case '(':
                        validator.Push(charString[i]);
                        break;
                    case '[':
                        validator.Push(charString[i]);
                        break;
                    case '{':
                        validator.Push(charString[i]);
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
                        break;
                    default:
                        break;
                }
            }

            if (validator.Top == null)
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
