using KateLab4;
using lab;

namespace Katelab4
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Money money = new Money();
            double num = money.Kops(10, 5);
            Console.WriteLine(num);

            MoneyArray.MoneyArray(10);
            int size = Convert.ToInt32(Console.ReadLine());
            MoneyArray.MoneyArray(size);
            int[] mas = new int[size];
            for (int i = 0; i < size; i++)
                mas[i] = Convert.ToInt32(Console.ReadLine());
            MoneyArray.MoneyArray(mas);

            MoneyArray.MoneyArray(size);
            MoneyArray[] mas1 = new MoneyArray[size];
            int max = 0;
            for (int i = 0; i < size; i++)
            {
                if(max < MoneyArray.Num(mas1[i]))
                    max = MoneyArray.Num(mas1[i]);
            }
            Console.WriteLine(max);

        }
    }
}