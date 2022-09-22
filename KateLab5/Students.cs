namespace KateLab5
{
    class Students
    {
        public int Id { get; set; }

        public Students(int id)
        {
            Id = id;
            
        }
        public void Print(int id)
        {
            String[] FirstName = { "Danil", "Kate", "Arsen", "John", "Nikita", "Dima", "Liza", "Marina" };
            Console.WriteLine(FirstName[id]);
            
        }
    }
}