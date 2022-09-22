using System.Collections;
using System.Collections.Generic;

namespace KateLab5
{


    public class Documents : Iinit, Icloneable
    {
        public int Weigth { get; set; }
        public int Heigth { get; set; }
        public string Color { get; set; }

        object Icloneable.Clone()
        {
            return MemberwiseClone();
        }
        //object Icloneable.Clone() => new Documents(Weigth, Heigth, Color);
        // Глубокое копирование убрать из комментария и закоммениторывать метод выше
        private class SortWeigthHelp : IComparer
        {
            public int Compare(object? x, object? y)
            {
                Documents doc1 = (Documents)x;
                Documents doc2 = (Documents)y;

                if (doc1 == null || doc2 == null)
                    return 0;
                if (doc1.Weigth > doc2.Weigth)
                    return 1;
                else
                    return -1;
            }
        }

        private class SortHeigthHelp : IComparer
        {
            public int Compare(object? x, object? y)
            {
                Documents doc1 = (Documents)x;
                Documents doc2 = (Documents)y;

                if (doc1 == null || doc2 == null)
                    return 0;
                if (doc1.Heigth > doc2.Heigth)
                    return 1;
                else
                    return -1;
            }

        }


        public Documents()
        {

        }
        public Documents(int weigth, int heigth, string color)
        {
            Weigth = weigth;
            Heigth = heigth;
            Color = color;
        }


        public void ColorPrint()
        {
            Console.WriteLine(Color);
        }
        
        public void Init()
        {
            throw new NotImplementedException();
        }

        public static IComparer SortWeigth()
        {
            return new SortWeigthHelp();
        }

        public static IComparer SortHeight()
        {
            return new SortHeigthHelp();
        }

       
    }
}