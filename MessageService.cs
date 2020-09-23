using System;

namespace csharp_lambda
{
    public class MessageService
    {
        private const string Value = "Message Service : Sending a text message";

        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            System.Console.WriteLine(Value + e.Video.Title);
        }

        public void OnVideoEncodedGeneric(object source, VideoEventArgs e)
        {
            System.Console.WriteLine("Message Service OnVideoEncodedGeneric" + e.Video.Title);
        }

        public void OnVideoEncodedCustom1(string Title) {
            System.Console.WriteLine("Message Service OnVideoEncodedCustom" + Title);
        }
    }
}