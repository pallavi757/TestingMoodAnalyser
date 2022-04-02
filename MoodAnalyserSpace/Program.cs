using System;
namespace MoodAnalyserTest
{
    public class MoodAnalyser
    {
        public string Message;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string Message)
        {
            this.Message = Message;
        }
        public string AnalyserMood()
        {
            try
            {
                if (Message.Contains("SAD"))
                    return "SAD";
                else return "HAPPY";
            }
            catch(NullReferenceException)
            {
                return "HAPPY";

            }
        }
        static void Main(string[] args)
        {

        }
    }
}