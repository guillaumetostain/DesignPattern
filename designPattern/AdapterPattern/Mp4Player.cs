using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.AdapterPattern
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayMp4()
        {
            Console.WriteLine("Playing Mp4 file");
        }

        public void PlayVlc()
        {
            
        }
    }
}
