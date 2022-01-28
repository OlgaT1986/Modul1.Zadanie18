using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            // считывается строка
            string str = Console.ReadLine(); 
            // проверка строки Check, затем вывод
            Console.WriteLine(Check(str)); 
            Console.ReadKey();
        }
        // метод возвращает true или false
        static bool Check(string str)
        {
            // элемент стека char
            Stack<char> stack = new Stack<char>();
            // словарь с ключем-char-открытая скобка, в ячейке - соответствующая закрытая скобка
            Dictionary<char, char> sk = new Dictionary<char, char>
            {
                // (-ключ, )-значение
                {'(', ')' },
                {'{', '}' },
                {'[', ']' },
            };
            // переборка сточки посимвольно
            foreach (char c in str) 
            {
                // проверка если есть скобка то поместить соотвкствующую закрытую скобку
                if (c == '(' || c == '{' || c == '[') 
                    stack.Push(sk[c]);
                if (c == ')' || c == '}' || c == ']')
                {
                    // если стек пустой-прерываем метод и возращаем false
                    if (stack.Count == 0 || stack.Pop() != c) 
                    {
                        return false; 
                    }
                }
            }
            // вышли из цикла foreach, проверка не остался ли в стеке какой то элемент 
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}

