namespace KateLab9
{
    class MoneyArray : Money
    {
        Money[] mas;
        int size;
        int count = 0;

        public MoneyArray() // конструктор без параметров
        {
            size = 0;
            mas = new Money[size];
            Console.WriteLine(0);
        }
        public MoneyArray(int size) // конструктор с рандомным вводом элементов
        {
            mas = new Money[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                Money money1 = new Money(rnd.Next(0, 99), rnd.Next(0, 99));
                mas[i] = money1;
                Console.WriteLine(mas[i]);
            }

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
            get
            {
                // Получает значение и проверяет существиет ли такой индекс в массиве 
                if (index >= 0 && index < mas.Length)
                    return (MoneyArray)mas[index]; // Возвращается объект по индексу
                else
                    throw new ArgumentOutOfRangeException("index"); // генерация исключения индекса
            }
            set
            {
                // Устанавливает индекс в массиве
                if (index >= 0 && index < mas.Length)
                    mas[index] = value;
            }
        }
    }
}

