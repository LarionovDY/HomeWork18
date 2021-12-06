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
            Console.WriteLine("Введите строку включающую в себя скобки {}, [], () для проверки правильности их расстановки");
            string str = Console.ReadLine();
            bool accuracy = AccuracyBrackets(str);
            Console.WriteLine("Скобки во введенной строке расставлены {0}", accuracy? "правильно":"неправильно");
            Console.ReadKey();
        }
        public static bool AccuracyBrackets(string str)
        {            
            Stack<char> myStack = new Stack<char>();
            for (int i = 0; i < str.Length; i++)        //для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая
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
                if (myStack.Count() > 0 && str[i] == myStack.Peek())        //при соответствии скобке в строке скобки помещенный в стек, скобка извлекается из стека                                                                           
                {
                    myStack.Pop();
                }
                else if ((myStack.Count() == 0 || myStack.Peek() != str[i]) && (str[i] == '}' || str[i] == ']' || str[i] == ')'))       //если закрывающая скобка в тексте не соответствует помещенной или стек пуст метод возвращает false
                {
                    return false;
                }
            }            
            if (myStack.Count() == 0)       //если стек пуст метод возвращает true
            {
                return true;
            }
            else        //если в стеке присутствуют элементы метод возвращает false;
            {
                return false;
            }
        }
    }
}






