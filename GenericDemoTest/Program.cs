using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integer array
            int[] intArray = { 11,22,33,44,55 };
            MaximumGeneric<int> generic = new MaximumGeneric<int>(intArray);
            generic.PrintMaxValue();

            //Double array
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            MaximumGeneric<double> genericDouble = new MaximumGeneric<double>(doubleArray);
            genericDouble.PrintMaxValue();

            //String array
            string[] stringArray = {"Apple","Peach","Banana" };
            MaximumGeneric<string> genericString = new MaximumGeneric<string>(stringArray);
            genericString.PrintMaxValue();
            Console.ReadLine();

        }

    }

}