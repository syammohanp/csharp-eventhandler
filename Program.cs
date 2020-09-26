using System;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.ComTypes;
using csharp_lambda;

namespace csharp_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
           MathService mathServ = new MathService();
           mathServ.MathPerformed += OnMathPerformed;
           mathServ.MathPerformed += delegate(object sernder, MathPerformedEventArgs e) {
               Console.WriteLine("Calculation Result from inline delegate" + e.Result);
           };
            mathServ.MathPerformed += (sernder, e) => {
               Console.WriteLine("Calculation Result from inline lambda" + e.Result);
           };
           mathServ.MultiplyNumebrs(12.2,2.0);

           var video = new Video() { Title = "Video 1"};
           var videoEncoder = new VideoEncoder();//publisher
           var mailService = new MailService();//subscriber
           var messageService = new MessageService();//Subscriber
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.VidoeEncodedGeneric += messageService.OnVideoEncodedGeneric;
            videoEncoder.VideoEncodedCustom += messageService.OnVideoEncodedCustom1;
            videoEncoder.Encode(video);

            //Action and Func
            var addition = new addition();
            var convertToArray = new convertToArray();
            addition.ConvertToDoubleArray += convertToArray.onConvertToDoubleArray;
            string[] input = new string[]{"1","2","3","4","5"};
            // Console.WriteLine("Main method calling GetFinalResult" + addition.GetFinalResult(input).ToString());
            Console.WriteLine("Main method calling GetFinalResult" + addition.GetFinalResult(input, (val1) => val1.Where(i => true).Sum()).ToString());
        }

        static void OnMathPerformed(object sender, MathPerformedEventArgs e) {
            Console.WriteLine("Calculation Result" + e.Result);
        }
    }
}
