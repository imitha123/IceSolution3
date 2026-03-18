using System;
using System.Speech.Synthesis;
using static System.Console;
namespace IceSolution3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

           
            AsciiClass myArt = new AsciiClass();
            myArt.art();
            MainExecution main = new MainExecution();
            main.Run();

            User_Voice myVoice = new User_Voice();
            myVoice.myVoice();
        }
    }
}
