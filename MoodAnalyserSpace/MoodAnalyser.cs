using MoodAnalyserSpace;
using System;

namespace MoodAnalyserSpace
{
    public class MoodAnalyser
    {
        private string _msg;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string message = "Null")
        {
            _msg = message;
        }

        public string AnalyserMood()
        {
            try
            {
                if (_msg.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }
              else if (_msg.Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                /// throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be Null");
                return "HAPPY";
            }
        }
    }
}