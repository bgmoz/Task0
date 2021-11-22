using System;
using Task0.MediaPlayerItem;

namespace Task0.MediaTypes
{
    public class Photo : MediaFile
    {
        public override void PlayFile(object MediaFileObject)
        {
            Console.WriteLine("Play Photo");
        }
    }
}
