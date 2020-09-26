using System;
using System.Linq;

namespace csharp_lambda
{
    public class convertToArray
    {
        public double[] onConvertToDoubleArray(string[] input) {
            Console.WriteLine("In onConvertToDoubleArray");
            string output = input.Select<string,double>(s => Double.Parse(s)).ToString();
            Console.WriteLine("String array select" + output );
            return(input.Select<string,double>(s => Double.Parse(s)).ToArray<double>());
        }
        
    }
}