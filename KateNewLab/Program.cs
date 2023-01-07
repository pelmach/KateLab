namespace KateNewLab
{
    class Program
    {
        public static void Main(String[] args)
        {
            Ranks rnk = new Ranks(); // Создание массива с длинной 10 с рандомными целыми числами
            int[] rank1 = rnk.Construct(10);
            Console.WriteLine(rank1);
            rnk.Check(rank1);


            int[] rank2 = { 0, 1, 1, 2, 3, 5 }; //Числа фибоначчи
            rnk.Check(rank2);

            int[] rank3 = { 0, 3, 6, 9, 12 }; //Арефметическая прогрессия
            rnk.Check(rank3);

            int[] rank4 = { 1, 2, 4, 8, 16, 32 }; //Геометрическая прогрессия
            rnk.Check(rank4);

            rnk.Sum(rank4);
            rnk.MasIndex(rank4, 8);
            rnk.MasThinkNum(rank4, 3);
            rnk.Max(rank1);
            rnk.Min(rank1);
        }
    }
}