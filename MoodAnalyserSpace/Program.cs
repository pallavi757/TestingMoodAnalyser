using MoodAnalyserSpace;
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
                if (Message.Equals(string.Empty))
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MOOD, "Mood should not be Empty");
                else if (this.Message.Contains("SAD"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                return "HAPPY";
            }
        }
    
        static void Main(string[] args)
        {

        }
    }
}
