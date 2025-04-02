using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
            {
                return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false; 
            }
            var sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum +=number;
                }
                else 
                {
                    sum += 0;
                }
                
            }
            
            if (sum % 2 == 0)
            {
                return false;
            }
           return true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsUpper = false;
            bool containsLower = false;
            bool containsNumber = false;

            foreach (var c in password)
            {
                if (char.IsUpper(c)) containsUpper = true;
                else if (char.IsLower(c)) containsLower = true;
                else if (char.IsNumber(c)) containsNumber = true;
                
                if (containsUpper && containsLower && containsNumber) 
                    return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            var letters = val.ToCharArray();
            return letters[0];
        }

        public char GetLastLetterOfString(string val)
        {
            var letters = val.ToCharArray();
            return letters[letters.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
