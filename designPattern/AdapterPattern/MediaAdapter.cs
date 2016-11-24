using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.AdapterPattern
{
    public class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(string mediaType)
        {
            if (mediaType.Equals("vlc"))
            {
                advancedMediaPlayer = new VlcPlayer();
            }
            else if (mediaType.Equals("mp4"))
            {
                advancedMediaPlayer = new Mp4Player();
            }
        }

        public void Play(string mediaType)
        {
            if (mediaType.Equals("vlc"))
            {
                advancedMediaPlayer.PlayVlc();
            }
            else if (mediaType.Equals("mp4"))
            {
                advancedMediaPlayer.PlayMp4();
            }
        }
    }
}
