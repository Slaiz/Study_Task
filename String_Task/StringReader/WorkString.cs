using System;

namespace StringReader
{
    public class WorkString
    {
        private char[] numb = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '\t' };

        private char[] letter = new char[]
        {
            'a', 'b', 'c', 'd', 'f', 'j', 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 's', 'g', 'h', 'k', 'k', 'l',
            'z', 'x', 'v', 'n', 'm'
        };


        private bool IsPalidrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;
            bool flag = true;

            for (; i <= j; i++, j--)
            {
                if (str[i] == str[j])
                {

                }
                else
                {
                    flag = false;
                    break;
                }
            }

            return flag;

        }

        public void WithoutNumbers(string str)
        {
            string[] str1 = str.Split(numb, StringSplitOptions.None);

            Console.WriteLine("String without numbers:");

            for (int k = 0; k < str1.Length; k++)
            {
                Console.Write(str1[k]);
            }
        }

        public void Info(string str)
        {
            if (IsPalidrome(str))
            {
                Console.WriteLine("String is palindrome !\n");
            }
            else Console.WriteLine("String is not palindrome !\n");

            int numbCount = 0;
            int leterUp = 0, letterDown = 0;
            int whiteSpaceCount = 0;

            string strUp = str.ToUpper();

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < numb.Length; j++)
                {
                    if (str[i] == numb[j])
                    {
                        numbCount++;
                    }
                }

                for (int j = 0; j < letter.Length; j++)
                {
                    if (str[i] == letter[j])
                        letterDown++;
                    if (str[i] == strUp[i] && char.ToLower(str[i]) == letter[j])
                        leterUp++;
                }

                if (str[i] == ' ')
                    whiteSpaceCount++;
            }

            Console.WriteLine("Statistics\nCount of Numbers: {0}\nCount of letter Up: {1}\nCount of letter Down: {2}\nCount of whitespace: {3}", 
                numbCount, leterUp, letterDown, whiteSpaceCount);
        }

        public void SymbolUp(string str, char ch)
        {
            int last = 0;

            char c;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                   c = char.ToUpper(str[i]);
                   str = str.Replace(str[i], c);
                   last = i;
                }
            }

            str.Remove(last);

            Console.WriteLine(str);
        }

        public void ReplaceWord(string str, string oldWr, string newWr)
        {
            str = str.Replace(oldWr, newWr);

            Console.WriteLine(str);
        }
    }
}