using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatistics
{
    class WordCounter
    {
        public void Count(string str)
        {
            Dictionary<string, int> wordList = new Dictionary<string, int>();
            string temp = null;
            string[] wordArr = new string[str.Length];
            int totalWordCount = 0;
            int uniqWordCount;
            int k = 0, p = 0, l = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || str[i] == '.' || str[i] == ',')
                {
                    for (int j = i-k; j < i ; j++)
                    {
                         temp = temp + str[j];
                    }
                    wordArr[p] = temp;
                    temp = null;
                    p++;
                    i++;
                    totalWordCount++;
                    k = 0;
                }
                k++;
            }

            int[] numb = new int[str.Length];
            k = 1;
            uniqWordCount = totalWordCount;
            Console.WriteLine();

            for (int i = 0; i < p; i++)
            {
                for (int j = i+1; j < p; j++)
                {
                    if (wordArr[i] == wordArr[j] && !numb.Contains(j))
                    {
                        numb[l] = j;
                        k++;
                        l++;
                    }
                }

                if (k != 1)
                    uniqWordCount = uniqWordCount - k + 1;

                if (!numb.Contains(i) || i == 0)
                    wordList.Add(wordArr[i],k);

                k = 1;
            }

            foreach (var word in wordList)
            {
                Console.WriteLine($"{k}. {word.Key:20} {word.Value}");
                k++;
            }
            
            Console.WriteLine("Total word: {0}\nUnique word: {1}\n", totalWordCount, uniqWordCount);         
        }
    }
}
