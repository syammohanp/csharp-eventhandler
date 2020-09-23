using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace csharp_lambda
{
    public class addition
    {
        public Func<string[],double[]> ConvertToDoubleArray;
        // public delegate double CalculationHandler(double[] input);
      
        public double GetFinalResult(string[] input, Func<double[],double> calc) {
            Console.WriteLine("In GetFinalResult");
            double[] vs = ConvertToDoubleArray?.Invoke(input);
            // return(addDobuleArray(vs)); Commented to work with a func
            return calc(vs);
            
        }

        public double addDobuleArray(double[] input) {
            Console.WriteLine("In addDobuleArray");
            return input.Where(i => i > 0).Sum();
        }

    }
}