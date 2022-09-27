
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(String[] args) 
    {
        //FirstTask();
        SecondTask();
    }

    public static void MasOut(char[,] mas)
    {
        for (int row = 0; row < mas.GetLength(0); row++)
        {
            for (int column = 0; column < mas.GetLength(1); column++)
                Console.Write(mas[row, column] + "\t");
            Console.WriteLine();
        }
    }

    public static void FirstTask()
    {
        Random rand = new Random(); 
        int x = 0;
        int n = 0; // ширина
        int m = 0; // длина
        Console.WriteLine("Введите размеры массива");
        n = Convert.ToInt32(Console.ReadLine());
        m = Convert.ToInt32(Console.ReadLine());
        char[,] mas = new char[n, m];
        Console.WriteLine("Заполнение массива: 1-ручное, 2-автоматическое");
        x = Convert.ToInt32(Console.ReadLine());
        if (x == 1) 
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = Convert.ToChar(Console.ReadLine());
                }
            }

        } else if (x == 2)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = Convert.ToChar(rand.Next('a', 'a' + 27));
                }
            }

        }
        MasOut(mas);
        Console.WriteLine();
        char[,] NewMas = new char[n, m];
        int index = -1;
        int num = 0;
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                if(Char.IsDigit(mas[i, j]) == true)
                {
                    index = j;
                    num++;
                }
                
            }
            for (int k = 0; k < mas.GetLength(1); k++)
            {
                if (num == 0)
                {
                    break;
                }
                else
                {
                    Console.Write(mas[i, k] + " ");
                }

            }
            index = -1;
            num = 0;
            Console.WriteLine();
                
        }
        
    }

    public static void SecondTask()
    {
        String str = Console.ReadLine();
        String[] strMas = str.Split(" ");
        for (int i = 0; i < strMas.Length; i++)
        {
            if(strMas[i][strMas[i].Length - 1] == '!')
            {
                strMas[i] = new String(strMas[i].Reverse().ToArray());
            }
        }
        String str2 = "";
        foreach (var item in strMas)
           str2 += item + " ";
        Console.WriteLine(str2);
    }
}
