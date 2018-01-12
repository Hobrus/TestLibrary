using System;

namespace TestLib
{
    public class Triangle
    {
        private double A, B, C, p, S; //Переменные класса
        public Triangle(double _A, double _B, double _C) //Конструктор класса
        {
            if (_A <= 0 || _B <= 0 || _C <= 0)  //Ошибка, если попытаемся ввести сторону для треугольника равную 0 или отрицательную
            {
                throw new IndexOutOfRangeException();
            }
            A = _A;
            B = _B;
            C = _C;
        }
        private double CalcS() //Внутренняя функция класса для вычисления площади
        {
            p = (A + B + C) / 2;
            S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return S;
        }
        public double GetS() //Функция, с помощью которой я получал площадь из конкретного экземпляра
        {
            CalcS();
            return S;
        }
    }
}
