using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.OOPS
{
    interface IPlayable
    {
        void Play(string format);
    }

    public class VideoPlayer : IPlayable
    {
        public void Play(string format)
        {
            Console.WriteLine($"You are Playing {format} File");
        }
    }

    public class MusicPlayer : IPlayable
    {
        public void Play(string format)
        {
            Console.WriteLine($"You are Playing {format} File");
        }
    }

    public class Playable
    {
        static void Main()
        {
            IPlayable music=new VideoPlayer();
            music.Play("Video");

            IPlayable music1 = new MusicPlayer();
            music1.Play("Music");
        }
    }

}
