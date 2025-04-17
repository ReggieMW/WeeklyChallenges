using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evens = 0;
            var odds = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                    evens += number;
                else
                {
                    odds -= number;
                }
            }
            return evens + odds;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> strings = new List<string> { str1, str2, str3, str4 };
            var shortest = strings.Min(x => x.Length);
            return shortest;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numbers = new List<int> { number1, number2, number3, number4 };
            var smallest = numbers.Min();
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }

            return false;
        } 

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullCount = objs.Count(x => x == null);
            if (nullCount > objs.Length / 2)
            {
                return true;
            }

            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            var avgEvens = (numbers ?? Array.Empty<int>()).Where(x => x % 2 == 0).DefaultIfEmpty(0).Average();
            return avgEvens;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
