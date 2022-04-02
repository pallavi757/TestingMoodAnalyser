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
            string result = " ";
            //Arrange
            moodAnalyser = new MoodAnalyser(result);
        }

        // TC-1.1 Given "I am in Sad mood" message should return SAD
        [Test]
        public void GivenMassage_When_ShouldReturnSad()
        {
            //Act
            string message = moodAnalyser.AnalyserMood("I am in SAD Mood");
            //Assert
            Assert.AreEqual("SAD", message);
        }

        // TC-1.2 Given "I am in Any mood" message should return HAPPY
        [Test]
        public void GivenMassage_When_ShouldReturnHappy()
        {
            //Act
            string message = moodAnalyser.AnalyserMood("I am in Any Mood");
            //Assert
            Assert.AreEqual("HAPPY", message);
        }
    }
}