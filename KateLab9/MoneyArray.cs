namespace KateLab9
{
    class MoneyArray : Money
    {
        Money[] mas;
        int size;
        int index = 0;
        int count = 0;

        public MoneyArray() // конструктор без параметров
        {
            size = 0;
            mas = new Money[size];
            Console.WriteLine(0);
        }
        public MoneyArray(int size) // конструктор с рандомным вводом элементов
        {
            Money money = new Money();
            Random rnd = new Random();
            mas = new Money[size];
            for (int i = 0; i < size; i++)
            {
                Money money1 = new Money(rnd.Next(0, 99), rnd.Next(0, 99));
                mas[i] = money1;
                count++;
            }
            Console.WriteLine(count);
            count = 0;
            
        }

        public MoneyArray(MoneyArray[] mas) // конструктор с вводом элементов с клавиатуры
        {
            for (int i = 0; i < size; i++)
            {
                Money money = new Money(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                mas[i] = (MoneyArray)money;
                count++;
            }
            Console.WriteLine(count);
            count = 0;

        }
        public MoneyArray this[int index] // индексатор
        {
            get => (MoneyArray)mas[index];
            set => mas[index] = value;

        }
        public void Show(int index) // просмотр элемента массива
        {
            
            MoneyArray moneyArray = this[index];
            Money money = moneyArray;
            money.Show(money);
        }
        
        }

    }
}