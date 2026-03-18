using System;
using System.Speech.Synthesis;
using static System.Console;



namespace IceSolution3
{
    internal class MainExecution
    {
        public void Run() {
            SpeechSynthesizer speech = new SpeechSynthesizer();

            Write("Which voice do you prefere between male and female >> ");
            string voice_choice = ReadLine();

            if (voice_choice.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                speech.SelectVoiceByHints(VoiceGender.Male);
            }
            else if (voice_choice.Equals("Female", StringComparison.OrdinalIgnoreCase))
            {
                speech.SelectVoiceByHints(VoiceGender.Female);
            }
            else
            {
                WriteLine("Wrong Input, Please choose between male and female");
            }

            Write("Please enter your name >> ");
            string name = ReadLine();

            int hour = DateTime.Now.Hour;
            string greet_user;

            if (hour < 12)
            {
                greet_user = "Good Morning " + name;

            }
            else if (hour < 17)
            {
                greet_user = "Good Afternoon " + name;

            }
            else
            {
                greet_user = "Good Evening " + name;

            }
            speech.Speak(greet_user + "I am SuperBot,  How do you understand today's coding class");
            WriteLine(greet_user + " How do you understand today's coding class");

            string answer = ReadLine().ToLower();
            if (answer.Contains("good") || answer.Contains("great") || answer.Contains("fine") || answer.Contains("Easy"))
            {
                speech.Speak("Well that's great, would you like me to give you an exercise on what you did");
            }else if (answer.Contains("bad") || answer.Contains("not good") || answer.Contains("Hard"))
            {
                speech.Speak("I am sorry to hear that. Would like me to help you improve");
            }

            Console.WriteLine("Hello");





        }
      
    }
}