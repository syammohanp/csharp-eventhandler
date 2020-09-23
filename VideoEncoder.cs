using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace csharp_lambda
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class VideoEncoder
    {
        //1. Define a delegate, contract between publisher and subscriber. 
        //2. Define an event based on the delegate
        //3. Raise the event
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        //New event handler
        public event EventHandler<VideoEventArgs> VidoeEncodedGeneric;
        public event EventHandler VidoeEncodedNormal;

        //Deleget with own parameter
        public delegate void VideoEncodedEventHadlerCustom(string title);
        public event VideoEncodedEventHadlerCustom VideoEncodedCustom;
        public void Encode(Video video) {
            Console.WriteLine("Enconding video");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
            OnVideoEncodedGeneric(video);
            OnVideoEncodedCustom(video);
        }
        protected virtual void OnVideoEncoded(Video video) => VideoEncoded?.Invoke(this, new VideoEventArgs(){ Video = video});

        protected virtual void OnVideoEncodedGeneric(Video video)
        {
            VidoeEncodedGeneric?.Invoke(this, new VideoEventArgs() { Video = video });
        }

        protected virtual void OnVideoEncodedCustom(Video video) => VideoEncodedCustom?.Invoke(video.Title);

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}