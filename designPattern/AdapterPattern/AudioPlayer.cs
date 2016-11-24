using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.AdapterPattern
{
    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter mediaAdapter;

        public void Play(string mediaType)
        {
            if (mediaType.Equals("vlc") || mediaType.Equals("mp4"))
            {
                mediaAdapter = new MediaAdapter(mediaType);
                mediaAdapter.Play(mediaType);
            }
            else
            {
                Console.WriteLine(mediaType + " format is not supported");
            }
        }
    }
}
