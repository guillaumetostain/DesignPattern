using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.AdapterPattern
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4()
        {
           
        }

        public void PlayVlc()
        {
            Console.WriteLine("Playing Vlc file");
        }
    }
}
