using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class RectangleTestDrive
    {
        public void StartTest()
        {
            while (true)
            {
                double side1 = 0, side2 = 0;
                bool side1Approve = false, side2Approve = false;

                Console.WriteLine("Введите два числа для сторон прямоугольника: \n");

                do
                {
                    try
                    {
                        Console.WriteLine("Сторона А: \n");
                        side1 = Convert.ToDouble(Console.ReadLine());
                        side1Approve = true;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильное значеие. Введите число: \n");
                    }
                }
                while (!side1Approve);

                do
                {
                    try
                    {
                        Console.WriteLine("Сторона Б: \n");
                        side2 = Convert.ToDouble(Console.ReadLine());
                        side2Approve = true;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильное значеие. Введите число: \n");
                    }
                }
                while (!side2Approve);

                Rectangle rect = new Rectangle(side1, side2);
                Console.Clear();
                Console.WriteLine("Периметр: {0} \nПлощадь: {1} \nНажмите, чтоб продолжить.", rect.Perimetr, rect.Area);
                Console.ReadKey();
                Console.Clear();
            }
        }


    }
}
