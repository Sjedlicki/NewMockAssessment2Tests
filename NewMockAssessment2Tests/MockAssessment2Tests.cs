using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NewMockAssessment2Tests
{
    public class MockAssessment2Tests
    {
        [Fact]
        public static void AddToArray()
        {
            string[] characters = { "Darth", "Yoda", "Luke" };

            int expected = 1;
            int actual = Challenge.AddStarWarsCharacters(characters);


            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void TestOfStrength()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Yoda", 4500000);
            dictionary.Add("Darth", 60200);
            dictionary.Add("Luke", 3000);

            string expected = "Yoda".ToLower();

            string actual = Challenge.DeathStarCombat(dictionary).ToLower();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public static void ReverseFromList()
        {
            string[] planets = new string[] { "Tatooine", "Alderaan", "Hoth" };
            
            List<string> expected = new List<string> { "Hoth", "Alderaan", "Tatooine" };
            List<string> actuals = Challenge.ConvertPlanets(planets);

            expected.ForEach(expect => expect.ToLower());
            actuals.ForEach(actual => actual.ToLower());

            Assert.Equal(expected, actuals);
        }

        [Fact]
        public static void AverageOfList()
        {
            List<int> droids = new List<int> {1, 5, 8, 22, 13, 88, 19, 48, 92, 81, 33, 63, 54 };

            double sum = 0;
            int count = 0;
            foreach(int even in droids)
            {
                if(even % 2 == 0)
                {
                    sum += even;
                    count++;
                }
            }

            double expected =  sum / count;
            double actual = Challenge.AverageDroids(droids);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void VaderWasCaptured()
        {
            string expected = "Vader Was Captured!".ToLower();
            string actual = Challenge.TryToCatchDarthVader("1").ToLower();

            Assert.Contains(expected, actual);
        }

        [Fact]
        public static void VaderGotAway()
        {
            string expected = "Vader Got Away".ToLower();
            string actual = Challenge.TryToCatchDarthVader("Vader Haters").ToLower();

            Assert.Contains(expected, actual);
        }
    }
}
