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
            string str = "([}{})[]"; //"Программирование — это (как [бить] {себя} по лицу,) рано[] или поздно ваш нос будет кровоточить.";
            Stack<char> myStack = new Stack<char>();
            bool accuracyCount = false;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
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
                if (myStack.Count() != 0 && str[i] == myStack.Peek())
                {
                    myStack.Pop();
                    accuracyCount = false;
                }
                else if (myStack.Count() == 0 && (str[i] == '}' || str[i] == ']' || str[i] == ')'))
                {
                    accuracyCount = false;
                }
            }
            if (myStack.Count() != 0)
            {
                accuracyCount = false;
            }
            foreach (char item in myStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(accuracyCount);
            Console.ReadKey();
        }
    }
}






