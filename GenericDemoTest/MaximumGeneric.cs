using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoTest
{
    public class MaximumGeneric<T>
    {

        public T[] value;
        public MaximumGeneric(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        void add(params int[] a) //specify a method parameter
        {

        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);

            return sorted_values[sorted_values.Length - 1];
        }

        public T MaxMethod() //To get max value
        {
            var max = MaxValue(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max); //print max value
        }
    }
}
    
