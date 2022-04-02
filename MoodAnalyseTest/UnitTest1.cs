using NUnit.Framework;
using MoodAnalyserTest;

namespace MoodAnalyseTest
{
    public class Tests
    {
        MoodAnalyser moodAnalyser;
        [SetUp]
        public void Setup()
        {
            moodAnalyser = new MoodAnalyser();
        }

        // TC-1.1 Given "I am in Sad mood" message should return SAD
        [Test]
        public void GivenMassage_When_ShouldReturnSad()
        {
            string message = moodAnalyser.AnalyserMood("I am in SAD Mood");
            Assert.AreEqual("SAD", message);
        }

        // TC-1.2 Given "I am in Any mood" message should return HAPPY
        [Test]
        public void GivenMassage_When_ShouldReturnHappy()
        {
            string message = moodAnalyser.AnalyserMood("I am in Any Mood");
            Assert.AreEqual("HAPPY", message);
        }
    }
}