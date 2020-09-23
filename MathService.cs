using System;
using System.Security;
using System.Security.Cryptography;
using System.Threading;
using System.Timers;

namespace csharp_lambda
{
    public class MathService
    {
        public event EventHandler<MathPerformedEventArgs> MathPerformed;

        public void MultiplyNumebrs(double val1, double val2){
            System.Timers.Timer timer = new System.Timers.Timer(5000);
            Thread.Sleep(2000);
            MathPerformed(this, new MathPerformedEventArgs {Result = val1 * val2});

        }
    }
}