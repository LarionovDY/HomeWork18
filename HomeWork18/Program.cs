using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork18
{
    class Program
    {
        //Дана строка, содержащая скобки трёх видов(круглые, квадратные и фигурные) и любые другие символы.
        //Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{ })[] скобки расставлены корректно, а в строке([]] — нет.
        //Указание: задача решается однократным проходом по символам заданной строки слева направо;
        //для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека
        //(при этом скобка с вершины стека снимается); в конце прохода стек должен быть пуст.
        static void Main(string[] args)
        {
            string str = "}([])"; //"Программирование — это (как [бить] {себя} по лицу,) рано[] или поздно ваш нос будет кровоточить.";
            bool accuracy = AccuracyBrackets(str);
            Console.WriteLine(accuracy);
            Console.ReadKey();
        }
        public static bool AccuracyBrackets(string str)
        {
            char[] charArray = str.ToCharArray(); 
            Stack<char> myStack = new Stack<char>();            
            for (int i = 0; i < charArray.Length; i++)
            {
                if ((charArray[i] == '}' || charArray[i] == ']' || charArray[i] == ')') && myStack.Count() == 0)
                {
                    return false;
                }
                switch (charArray[i])
                {
                    case '{':
                        myStack.Push('}');
                        break;
                    case '[':
                        myStack.Push(']');
                        break;
                    case '(':
                        myStack.Push(')');
                        break;
                }
                if (myStack.Count() != 0 && charArray[i] == myStack.Peek())
                {
                    myStack.Pop();
                }
            }
            if (myStack.Count() == 0)
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






