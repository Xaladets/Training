using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static bool start = true;  //Задаёт переменной start значение "неверно"
        static bool exit = false;  //Задаёт переменной exit значение "неверно"
        float one = 0;  //Вместо int, которое представляет целое число, я использовал float, которое может представлять число с запятой
        float two = 0;
        char task = '\0';  //char представляет элемент, как символ
        static void Main(string[] args)
        {
            if (exit) Console.WriteLine("Правда");

            else if (start) Console.WriteLine("Лош");

        }

    }

}
//Для Юрчика: Норм ли вышло? Можно было бы как-нибудь сократить или так норм? Я на это потратил 5 часов, 3 из которых подбирал методы, чтобы это работало. Однако...ОНО РАБОТАЕТ!!!