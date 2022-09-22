using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KateLab5
{   
    interface Icloneable
    {
        object Clone();
    }
    interface Iinit
    {
        int Weigth { get; set; }
        int Heigth { get; set; }
        string Color { get; set; }

        void Init()
        {
            Random random = new Random();
            Weigth = random.Next(0, 100);
            Heigth = random.Next(0, 100);
            String[] masStr = new string[] { "Black", "White", "Blue", "Crey", "PaperColor", "Red", "Orange", "Green" };
            Color = masStr[random.Next(0, 7)];
        }
        void Info()
        {

        }
    }
    class Program
    {
        public static void Main(String[] args)
        {
            Documents[] docMas = new Documents[2];
            Cheque Cq = new Cheque(10, 5, "black", 2.5);
            docMas[0] = Cq;
            Receipt Rt = new Receipt(6, 7, "black", 5.6, "Arsen");
            docMas[1] = Rt;
            Invoce In = new Invoce(11, 8, "black", 19.2, "Kate", "Iphone 14PRO_COLD_MAXImum");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 2; i++)
            {
                if (i == num)
                    Console.WriteLine(docMas[i]);
            }
            Cq.ColorPrint();
            Rt.ColorPrint();
            In.ColorPrint();

            Random rd = new Random();
            int id = rd.Next(0, 8);
            Students st = new Students(id);
            Compar(st);
            Compar2(Cq);
            Compar3(Cq);

            RealiseIinit Newclass = new RealiseIinit();
            Newclass.Init();
            Iinit[] iinits = { 
                new RealiseIinit(),
                new Documents(10, 10, "Black"),
                new Invoce(15, 20, "White", 2.40, "Arsen", "phone"),
                new Cheque(35, 5, "Crey", 5.4),
                new Receipt(5, 24, "Red", 1.44, "Arsen")
            };

            foreach (Documents c in iinits)
                Console.WriteLine(c.Heigth + "\t\t" + c.Weigth);
            Console.WriteLine();

            Array.Sort(iinits);
            foreach (Documents c in iinits)
                Console.WriteLine(c.Heigth + "\t\t" + c.Weigth);

            Array.Sort(iinits, Documents.SortWeigth());
                foreach (Documents c in iinits)
                Console.WriteLine(c.Weigth + "\t");

            Array.Sort(iinits, Documents.SortHeight());
            foreach (Documents c in iinits)
                Console.WriteLine(c.Heigth + "\t");

            object Myobject = 1;
            FindObject(iinits, Myobject);


        }

        public static void FindObject(Array mas, object MyObject)
        {
            int index = Array.BinarySearch(mas, MyObject);
            if(index < 0)
            {
                Console.WriteLine("Объект не найден", MyObject, ~index);

            }
            else
            {
                Console.WriteLine("Объект найден", MyObject, index);
            }
        }

        public static void Compar(object odj)
        {
            Students students = odj as Students;
            Random random = new Random();
            
            if(students != null)
                students.Print(random.Next(0, 8));
        }

        public static void Compar2(object obj)
        {
            Cheque cheque = obj as Cheque;
            if (cheque != null)
                cheque.Info();

        }

        public static void Compar3(object obj)
        {
            Cheque[] cheques = new Cheque[10];
            int num = 0;
            foreach (Cheque p in cheques)
                if (p is Documents)
                    num++;
            Console.WriteLine(num);
        }
        
    }
    

    }
