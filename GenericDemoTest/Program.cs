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
            Console.WriteLine("FInd Max Number");
            int output = MaximumNumber.MaximumIntegerNumber(11,22,33);
            Console.WriteLine(output);
            Console.ReadLine();
            Console.WriteLine("Find Max Double");
            double output1 = MaximumNumber.MaximumDoubleNumber(20.21, 22.2, 33.00);
            Console.WriteLine(output1);
            Console.ReadLine();
          
        }

      
    }

}