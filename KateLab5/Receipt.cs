namespace KateLab5
{
    class Receipt : Documents
    {
        public double Count { get; set; }
        public string Person { get; set; }
        public Receipt()
        {

        }
        public Receipt(int weigth, int heigth, string color, double count, string person) : base(weigth, heigth, color)
        {
            Count = count;
            Person = person;
        }
        public override void Info()
        {
            Console.WriteLine("Receipt");
            Console.WriteLine($"Weigth: {Weigth} \n" +
                              $"Heigth: {Heigth} \n" +
                              $"Color: {Color} \n");
            Console.WriteLine($"Count: {Count} \n" + 
                              $"Person: {Person} \n");
        }
    }
}