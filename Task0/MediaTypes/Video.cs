using System;
using Task0.MediaPlayerItem;


namespace z0.MediaTypes
{
    public class Video : MediaFile
    {
        public override void PlayFile(object MediaFileObject)
        {
            Console.WriteLine("Play Video");
        }
    }
}
