using System;
using System.Collections.Generic;
using Task0.MediaPlayerItem;



namespace Task0
{
    public class PlayListAtions : MediaPlayer
    {

        
       
         public override void Add(object MediaFileObject)
        {
          
            playList.Add((MediaFile)MediaFileObject);
        }

        public override void Remove(object MediaFileObject)
        {
            playList.Remove((MediaFile)MediaFileObject);
        }

        public override void ShovList(string ListName)
        {

        }
    }
}
