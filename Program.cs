using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;
using System.IO;

namespace ThreadHW
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Thread PlayMusic = new Thread(Music);
            PlayMusic.IsBackground = true;
            Text();
            PlayMusic.Start();

        }

        static void Music()
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\БайназарС.CORP\source\repos\ThreadHW\rammstein_-_deutschland.wav");
            soundPlayer.Play();
        }

        static void Text()
        {
            string write = @"C:\Users\БайназарС.CORP\source\repos\ThreadHW\qwe.txt";
            string text = Console.ReadLine();
            using(StreamWriter writer = new StreamWriter(write, false, System.Text.Encoding.Default))
            {
                writer.WriteLine(text);
            }
        }
    }
}
