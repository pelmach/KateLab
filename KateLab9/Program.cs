
namespace KateLab9
{
    class Program
    {
        public static void Main(String[] args)
        {
            Money money = new Money(5, 40);
            money.Show(money);

            MoneyArray mas = new MoneyArray(3);
            mas.Show(1);

            MoneyArray moneyArray = new MoneyArray();
            moneyArray.Show(moneyArray);
            MoneyArray moneyArray1 = new MoneyArray(5);
            moneyArray1.Show(moneyArray1);

            Random rnd = new Random();
            Money money1 = new Money(rnd.Next(0, 99), rnd.Next(0, 99));
            Money money2 = new Money(rnd.Next(0, 99), rnd.Next(0, 99));
            int max = 0;
            money1.Show(money1);
            money2.Show(money2);
            int rub1 = money1.Rubles;
            int rub2 = money2.Rubles;
            if(rub1 > rub2)
            {
                Console.WriteLine(rub1);
            } else
            {
                Console.WriteLine(rub2);
            }

        }
    }

   
}
