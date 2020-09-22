using System;
using System.Reflection;
using System.Reflection.PortableExecutable;
using csharp_lambda;

namespace csharp_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
           MathService mathServ = new MathService();
           mathServ.MathPerformed += OnMathPerformed;
           mathServ.MultiplyNumebrs(12.2,2.0);

           var video = new Video() { Title = "Video 1"};
           var videoEncoder = new VideoEncoder();//publisher
           var mailService = new MailService();//subscriber
           var messageService = new MessageService();//Subscriber
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.VidoeEncodedGeneric += messageService.OnVideoEncodedGeneric;
            videoEncoder.Encode(video);
        }

        static void OnMathPerformed(object sender, MathPerformedEventArgs e) {
            Console.WriteLine("Calculation Result" + e.Result);
        }
    }
}
