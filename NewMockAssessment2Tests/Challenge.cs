using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewMockAssessment2Tests
{
    class Challenge
    {
        public static int AddStarWarsCharacters(string[] characters)
        {
            for(int i = 0; i < characters.Length; i++)
            {
                if(characters[i] == "Yoda")
                {
                    return i;
                }
            }

            return -1;
        }

        public static string DeathStarCombat(Dictionary<string, int> characters)
        {
            int max = characters.Values.Max();

            foreach (KeyValuePair<string, int> kvp in characters)
            {
                if(kvp.Value == max)
                {
                    return kvp.Key;
                }
            }

            return "";
        }

        public static List<string> ConvertPlanets(string[] planets)
        {
            List<string> reversePlanets = new List<string>();
            for (int i = planets.Length - 1; i >= 0; i--)
            {
                reversePlanets.Add(planets[i]);
            }
            return reversePlanets;
        }

        public static double AverageDroids(List<int> droids)
        {
            double sum = 0;
            int count = 0;

            foreach(int droid in droids)
            {
                if(droid % 2 == 0)
                {
                    sum += droid;
                    count++;
                }
            }

            return sum / count;
        }

        public static string TryToCatchDarthVader(string vader)
        {
            try
            {
                int.Parse(vader);
                return "Vader was captured!";
            }
            catch(FormatException)
            {
                return "Vader got away!";
            }
        }
    }
}
