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
            moodAnalyser = new MoodAnalyser("I am in SAD Mood");
            //Act
            string message = moodAnalyser.AnalyserMood();
            //Assert
            Assert.AreEqual("SAD", message);
        }

        // TC-1.2 Given "I am in Any mood" message should return HAPPY
        [Test]
        public void GivenMassage_When_ShouldReturnHappy()
        {
            moodAnalyser = new MoodAnalyser("I am in ANY Mood");
            //Act
            string message = moodAnalyser.AnalyserMood();
            //Assert
            Assert.AreEqual("HAPPY", message);
        }
        // TC-2.1 Given Null Mood Should Return Happy
        [Test]
        public void GivenMessage_WhenNull_ShouldReturnHappy()
        {
            moodAnalyser = new MoodAnalyser();
            //Act
            string message = moodAnalyser.AnalyserMood();
            //Assert
            Assert.AreEqual("HAPPY", message);
        }
    }
}