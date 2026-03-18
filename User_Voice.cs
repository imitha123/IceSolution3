using System;
using System.IO;
using System.Media;

namespace IceSolution3
{
    internal class User_Voice
    {
        public void myVoice()
        {
            // full path 
            string path_directory = AppDomain.CurrentDomain.BaseDirectory;
            // path to the record
            Console.WriteLine(path_directory);
            string recordPath = path_directory.Replace("\\bin\\Debug", "");
            Console.WriteLine(recordPath);
        //C: \Users\Student\source\repos\IceSolution3\Recording.wav

            // combine the recordPath & the name of the file recording
            string record = Path.Combine(recordPath, "Recording.wav");

            play_voice(record);
        }

        public void play_voice(string voice)
        {
            try
            {
                using (SoundPlayer soundPlayer = new SoundPlayer(voice))
                {
                    soundPlayer.PlaySync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}