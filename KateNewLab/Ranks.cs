using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KateNewLab
{
    class Ranks
    {
        int n; // Поле класс - колво чисел
        int[] nums; // Поле класс - массив целых чисел

        public Ranks() // Пустой конструктор класса
        {

        }

        public int[] Construct(int n) // При заданном n создает массив
        {
            int[] mas = new int[n];
            if (n > 0 || n <= 50) // Если в заданном диапозоне находится n, то создает массив длины n и забивает его рандомными значениями
            {
                Random rnd = new Random();
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rnd.Next(1, 50);
                    Console.Write(mas[i] + " ");
                }
            }
            return mas;
        }

        public void Check(int[] mas) // Проверяет к какому виду числовой последовательности принадлежит массив и вывод название числовой последовательности
        {
            bool num1 = Fibonachi(mas);
            if (num1 == true) Console.WriteLine("Ряд Фибоначчи");
            else
            {
                num1 = ArithmeticProg(mas);
                if (num1 == true) Console.WriteLine("Арефметическая прогрессия");
                else
                {
                    num1 = GeometricProg(mas);
                    if (num1 == true) Console.WriteLine("Геометрическая прогрессия");
                    else Console.WriteLine("Ряд несвязанных чисел");
                }
            }
        }

        // Здесь три метода, которые проверяют каждый элемент массива и если все элементы подходят определенной последовательности, то они возвращают в метод проверки true
        public bool Fibonachi(int[] mas) // Проверка массива является ли он числами фибоначчи
        {
            int[] numbers = new int[mas.Length];
            numbers[0] = 0;
            int curr = 1;
            int next = 1;
            for (int i = 1; i < numbers.Length; i++) // Создали новый массив, который равен длине заданного массива и заполнили его, как заполняются числа фибоначи
            {
                numbers[i] = curr;
                next = numbers[i - 1] + curr;
                curr = next;

            }

            int k = 0;
            for (int i = 0; i < numbers.Length; i++) // Сравниваем элементы заданного массива и нового, увеличивает считчик одинаковых элементов
            {
                if (numbers[i] == mas[i]) k++;
            }

            if (k == mas.Length) return true; // Если счетчик равен длине заданного массива, то все элементы совпали и заданный массив является числами фибоначи
            else return false;

        }

        public bool ArithmeticProg(int[] mas) // Проверка массива является ли он арифметической прогрессией 
        {
            int a = 3; // Задаем множитель арифметической прогрессии
            int[] numbers = new int[mas.Length];
            numbers[0] = 0;
            for (int i = 1; i < numbers.Length; i++) // Создали новый массив, который равен длине заданного массива и заполнили его, как заполняются арифметическую прогрессию
            {
                numbers[i] = a + numbers[i - 1];
            }

            int k = 0;
            for (int i = 0; i < numbers.Length; i++) // Сравниваем элементы заданного массива и нового, увеличивает считчик одинаковых элементов
            {
                if (numbers[i] == mas[i]) k++;
            }

            if (k == mas.Length) return true; // Если счетчик равен длине заданного массива, то все элементы совпали и заданный массив является арифметической прогрессией
            else return false;
        }

        public bool GeometricProg(int[] mas) //Проверка является ли массив геометрической прогрессией
        {
            int a = 2; // задаем множитель геометрической прогрессии 
            int[] numbers = new int[mas.Length];
            numbers[0] = 1;
            for (int i = 1; i < numbers.Length; i++) //Создали новый массив, который равен длине заданного массива и заполнили его, как заполняются геометрическую прогрессию
            {
                numbers[i] = (int)Math.Pow(a, i);
            }

            int k = 0;
            for (int i = 0; i < numbers.Length; i++) // Сравниваем элементы заданного массива и нового, увеличивает считчик одинаковых элементов
            {
                if (numbers[i] == mas[i]) k++;
            }

            if (k == mas.Length) return true; // Если счетчик равен длине заданного массива, то все элементы совпали и заданный массив является геометрической прогрессией
            else return false;
        }

        public void Sum(int[] mas) // Считает сумму всех элементов массива
        {
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            Console.WriteLine("Sum = " + sum);
        }

        public void MasIndex(int[] mas, int num) // Выводит индекс элемента массива, если задать элемент массива
        {
            int result = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == num) result = i;
            }
            Console.WriteLine("Индекс определенного элемента массива = " + result);
        }

        public void MasThinkNum(int[] mas, int index) // Выводит значение элемента массива, если задать индекс элемента
        {
            Console.WriteLine("Значение определенного элемента массива = " + mas[index]);
        }

        public void Max(int[] mas) // Выводит максимальный элемент массива
        {
            int max = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (max < mas[i]) max = mas[i];
            }
            Console.WriteLine("Max = " + max);
        }

        public void Min(int[] mas) // Выводит минимальный элемент массива
        {
            int min = 99999;
            for (int i = 0; i < mas.Length; i++)
            {
                if (min > mas[i]) min = mas[i];
            }
            Console.WriteLine("Min = " + min);
        }
        
    }
}
