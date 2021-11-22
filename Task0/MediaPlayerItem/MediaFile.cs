namespace Task0.MediaPlayerItem
{
    public class MediaFile : MediaPlayer
    {
        string MediaFileName = null;
        string MediaFileTupe = null;

        public override object MediaFileObject
        {
            get { return (MediaFileName, MediaFileTupe); }
        }

    }
}