using System;
using System.Diagnostics;

namespace csharp_lambda
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class MailService
    {
        public void OnVideoEncoded(object source,
                                   VideoEventArgs e)
        {
            System.Console.WriteLine("Mail Service - Video Envoded Event Handler" + e.Video.Title);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}