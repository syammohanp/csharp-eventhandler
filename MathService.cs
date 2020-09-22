using System;
using System.Security;
using System.Security.Cryptography;
using System.Timers;

namespace csharp_lambda
{
    public class MathService
    {
        public event EventHandler<MathPerformedEventArgs> MathPerformed;

        public void MultiplyNumebrs(double val1, double val2){
            Timer timer = new Timer(5000);
            MathPerformed(this, new MathPerformedEventArgs {Result = val1 * val2});

        }
    }
}