using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TweetWatch
{
    internal class AlertSound
    {
        private SoundPlayer _sound;

        public AlertSound(string fileName)
        {
            if (File.Exists(fileName))
                _sound = new SoundPlayer(fileName);
        }

        public void Play()
        {
            if (_sound != null)
                _sound.Play();
            else
                SystemSounds.Beep.Play();
        }

    }
}
