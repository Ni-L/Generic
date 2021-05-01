using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class GenericClass
    {
        public static void ToPrintint<T>(T[] intarray)
        {
            foreach (var element in intarray)
            {
                Console.WriteLine(element);
                Console.ReadLine();
            }
        }
    }
}
