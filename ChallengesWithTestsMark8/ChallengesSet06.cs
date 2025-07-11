﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || word == null)
                return false;    
            
            if (ignoreCase)
            {
                string wordNoCase = word.ToLower();
                foreach (string item in words)
                    if (item != null && item.ToLower() == wordNoCase)
                        return true;
            }
            else
            {
                foreach (string wordCase in words)
                {
                    if (wordCase == word)
                        return true;
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
                return false;
            
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
                return -1;
            
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charCounts.ContainsKey(c))
                    charCounts[c]++;
                else
                {
                    charCounts[c] = 1;
                }
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (charCounts[str[i]] == 1)
                    return i;
            }

            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 1;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count < n || n <= 0)
            {
                return new double[0];
            }
            
            List<double> result = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }
            
            return result.ToArray();
        }
    }
}
