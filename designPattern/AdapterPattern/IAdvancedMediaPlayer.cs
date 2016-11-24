﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.AdapterPattern
{
    public interface IAdvancedMediaPlayer
    {
        void PlayVlc();
        void PlayMp4();
    }
}
