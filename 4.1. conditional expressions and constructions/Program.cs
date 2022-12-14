using System;

namespace MyNamespase
{
    class Myclass
    {
        public static void Main(string[] args)
        {
            var myapples = 5;
            var hisapples = 6;
            var hispeares = 5;

            var result = (myapples != hispeares) & (myapples < hisapples);

            Console.WriteLine(result);

            ////Задание 4.1.4
            //string a, b;
            //bool c = a != b;

            ////Задание 4.1.5
            //int A, B;
            //double X, Y;

            //bool C = (A < B) | (X > Y);

            var numberone = 7;      //Значение переменной изменено
            var numbertwo = 7;

            if (numberone == numbertwo)
            {
                Console.WriteLine("Условие истино");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            }
        }
    }
}