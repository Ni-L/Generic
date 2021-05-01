using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = {2,5,6,7,8,8,9 };
            double[] doublearray = { 22.33,22.66,22.33};
            char[] chararray = {'H','E','L','L','O','O' };

            //Call Methods
          // Program.ToPrintint(intarray);
            //Program.ToPrintDouble(doublearray);
            //Program.ToPrintchar(chararray);
            GenericClass
                .ToPrintint<int>(intarray);

        }
        public static void ToPriintint(int[] intarray)
        {
            foreach (int element in intarray)
            {
                Console.WriteLine(element);
                Console.ReadLine();
            }
        }

        public static void ToPrintDouble(double[] doublearray)
        {
            foreach(double element in doublearray )
            {
                Console.WriteLine(element);
                Console.ReadLine();
            }
        }
        public static void ToPrintchar(char[] chararray)
        {
            foreach (char element in chararray)
            {
                Console.WriteLine(element);
                Console.ReadLine();
            }
        }
    }
}
