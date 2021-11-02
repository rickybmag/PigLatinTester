using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    public class PigLatin
    {
        public bool IsVowel(char c)
        {
            //Testing showed that vowels chars were "false". Added foreach loop so it could iterate thru the vowel array and compare what was entered
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char letter in vowels)
            {
                if (c == letter)
                {
                    return true;
                }                
            }
            return false;
        }

        public string ToPigLatin(string word)
        {
            //bool will check for special characters in words
            bool hasSpecial = false;
            string[] words = word.Split();
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            word = word.ToLower();
            foreach (string phrase in words)
            {
                foreach (char c in specialChars)
                {
                    foreach (char w in word)
                    {
                        if (w == c)
                        {
                            Console.WriteLine("That word has special characters, we will return it as is");
                            hasSpecial = true;
                        }
                    }

                }
            }

            bool noVowels = true;
            foreach (char letter in word)
            {
                if (IsVowel(letter))
                {
                    noVowels = false;
                }
            }

            if (noVowels)
            {
                return word;
            }

            char firstLetter = word[0];
            string output = "placeholder";
            //added a 'w' to "ay"
            if (IsVowel(firstLetter) == true)
            {
                output = word + "way";
            }
            else
            {
                int vowelIndex = -1;
                //Handle going through all the consonants
                for (int i = 0; i <= word.Length; i++)
                {
                    if (IsVowel(word[i]) == true)
                    {
                        vowelIndex = i;
                        break;
                    }
                }


                string sub = word.Substring(vowelIndex);
                string postFix = word.Substring(0, vowelIndex);

                output = sub + postFix + "ay";
            }
            return output;
        }
    }
}
