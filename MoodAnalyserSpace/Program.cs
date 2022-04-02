using System;
namespace MoodAnalyserTest
{
    public class MoodAnalyser
    {
        public MoodAnalyser()
        {

        }
        public string AnalyserMood(string Message)
        {
            if (Message.Contains("SAD"))
                return "SAD";
            else return "HAPPY";
        }
        static void Main(string[] args)
        {

        }
    }
}