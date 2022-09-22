namespace KateLab5
{
    class Cheque : Documents
    {
        public double Price { get; set; }
        public Cheque()
        {

        }
        public Cheque(int weigth, int heigth, string color, double price) : base(weigth, heigth, color)
        {
            Price = price;
        }

        public override void Info()
        {
            Console.WriteLine("Chegue");
            Console.WriteLine($"Weigth: {Weigth} \n" +
                              $"Heigth: {Heigth} \n" +
                              $"Color: {Color} \n");
            Console.WriteLine($"Price: {Price} \n");
        }
    }
}