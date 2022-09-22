namespace KateLab9
{
    class Money
    {
        int rubles;
        int kopeks;
        static int count = 0; // считает созданное колво объектов класса
        public int Rubles
        {
            get { return rubles; } // Возвращает колво рублей
            set { rubles = value; } // Принимает значение рублей
        }
        public int Kopeks
        {
            get { return kopeks; } // Возвращает колво копеек
            set { // Принимает колво копеек 
                if (kopeks < 0 || kopeks > 99) // Проверка числа копеек
                    throw new ArgumentException("Копеек не может быть меньше нулю и больше 100");
                else 
                    if(rubles >= 0)
                {
                    value = rubles + kopeks; // Сумма копеек и рублей
                }
            } 
        }
        public Money() // Метод инициализации объектов класса 
        {
            count++;
            rubles = 0;
            kopeks = 0;

        }

        public Money(int rub, int kop) // Метод инициализации объектов класса
        {
            count++;
            rubles = rub;
            kopeks = kop;
        }

        public void Count() // Вывод колво созданных объектов класса
        {
            Console.WriteLine(count); 
        }

        public void Show(Money money) // Вывод рублей и копеек
        {
            if((rubles < 0) && (kopeks < 0) && (kopeks > 99))
            {
                Console.WriteLine("Введенно правальное значение величин");

            }
            else
            {
                Console.WriteLine("Рублей = " + rubles + " Копеек = " + kopeks);
            }
        }
        public static Money operator --(Money money) // унарный минус
        {
            if((money.kopeks <= 0) || (money.rubles <= 0))
            {
                money.rubles = 0;
                money.kopeks = 0; 
            } else
            {
                money.kopeks--;
            }
            return money;
        }
        
        public static Money operator ++(Money money) // унарный плюс
        {
            if(money.kopeks < 99)
                money.kopeks++;
            if (money.kopeks == 99)
                money.rubles++;
            return money;
        }

        public static Money Int(Money money) // неявное проеобразование 
        {
            if (money.kopeks == 0)
                return money;
            else
            {
                money.kopeks = 0;
                return money;
            }
        }

        public static double Double(Money money) // явное преобразование
        {
            List<double> num = new List<double>();
            num[0] = money.kopeks;
            return num[0];
        }
    }
}