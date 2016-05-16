using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace Animal_Noises
{
    public class Animal
    {
        private SoundPlayer soundPlayer;
        private String lockString;

        public Animal(String soundFileName, String lockString)
        {
            soundPlayer = new SoundPlayer(soundFileName);
            this.lockString = lockString;
        }

        public void speak()
        {
            while (true)
            {
                //locking the shared string so only one can play at a time
                lock (lockString)
                {
                    soundPlayer.Play();
                    Thread.Sleep(500);
                }
            }
        }

    }
}
