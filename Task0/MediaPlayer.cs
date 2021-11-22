using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task0.MediaPlayerItem;

namespace Task0
{
    public class MediaPlayer
    {


        public List<MediaFile> playList = new List<MediaFile> { };

        public virtual object MediaFileObject
        { get; set; }
       
       

        public virtual void PlayFile(object mediaFileObject)
        {
            
        }

        public virtual void Add(object mediaFileObject)
        {
   
        }
        public virtual void Remove(object mediaFileObject)
        {
    
        }

        public virtual void ShovList(string ListName)
        {

        }



    }
}
