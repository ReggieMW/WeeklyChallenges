using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //define what a letter is
            string letters = "abcdefghijklmnopqrstuvwxyz";
            
            //make all entries lower-case
            foreach (char letter in letters)
            {
                c = char.ToLower(letter);
            }
            
            //check to see if char is a defined letter
            if (c >= 'a' && c <= 'z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CountOfElementsIsEven(string[] vals)
        {
            //count elements
            int count = 0;
            foreach (var value in vals)
            {
                count++;
            }
            
            //check total to see if it is even
            if (count % 2 == 0)
            {
                return true;
            }
            return false;   
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length = 0;
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        { 
            int sum = 0;
            if (sum == null || sum == 0)
            {
                return 0;
            }
            
            foreach (int number in numbers)
                sum += number;
            return sum;
            
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Count() == 0)
                return  0;
            int evens = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                    evens += number;
                else evens += 0;
            }
            return evens;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
                return false;
            int isOdd = 0;
            foreach (int number in numbers)
            {
                isOdd += number;
            }
            return isOdd % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number == null || number == 1)
                return 0;
            long count = 0;

            while (number > 0)
            {
                if ((number-1) % 2 != 0)
                    count++;
                else 
                    count += 0;
                number--;
            }
            return count;
        }
    }
}
