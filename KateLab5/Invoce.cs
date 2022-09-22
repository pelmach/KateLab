namespace KateLab5
{
    class Invoce : Documents
    {
        public string Think { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string[] ThinkMas = { "Phone", "House", "Car", "Utility bills" };

        public Invoce()
        {

        }
        public Invoce(int weigth, int heigth, string color, double price, string name, string think) : base(weigth, heigth, color)
        {
            Think = think;
            Name = name;
            Price = price;
        }

        public override void Info()
        {
            Console.WriteLine("Invoice");
            Console.WriteLine($"Weigth: {Weigth} \n" +
                              $"Heigth: {Heigth} \n" +
                              $"Color: {Color} \n");
            Console.WriteLine($"Price: {Price} \n" +
                              $"Name: {Name} \n" +
                              $"Think: {Think} \n");
        }
    }
}