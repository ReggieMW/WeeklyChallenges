using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (n == 0)
                Console.WriteLine("n cannot be 0.");

            int nextNumber = startNumber + 1;
            while (nextNumber % n != 0)
            {
                nextNumber++;
            }
            return nextNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            };
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null)
                return false;

            if (numbers.Length  == 1)
                return true;
            
            if (numbers.Length < 1)
                return false;
            
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
                return 0;

            if (numbers.Length < 2)
                return 0;
            
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null)
                return "";
            
            var result = words.Where(w => !string.IsNullOrWhiteSpace(w)).Select(w => w.Trim());
            
            string sentence = string.Join(" ", result);
            
            return string.IsNullOrWhiteSpace(sentence) ? "" : sentence + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count < 4)
                return new double[] { };
                
            List<double> fourthElements = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                fourthElements.Add(elements[i]);
            }
            return fourthElements.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
                return false;
            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] + nums[i] == targetNumber)
                    {
                        return true;
                    }
                }
            return false;
        }
    }
}
