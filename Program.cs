using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyOfWords
{
    internal class program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hash table demo"); //() []
            //FrequancyPharse<string, string> hash = new FrequancyPharse<string, string>(5);
            //}
            FrequancyPharse<string, string> hash1 = new FrequancyPharse<string, string>(5);
            String sentence = "Paranoids Are Not Paranoid Because They Are Paranoid But Because They Keep Putting Themselves Deliberately Into Paranoid Avoidable Situations";

            //split is splitting a string into an array of substrings separated by a character
            string[] Phrase = sentence.Split(' ');
            int SLength = Phrase.Length;
            // Itreating along each word and adding it to hash set
            for (int i = 0; i < SLength; i++)
            {
                hash1.Add(Convert.ToString(i), Phrase[i]);
            }
            //iterating through each loop to get the frequency of each word in the sentence
            foreach (string word in Phrase)
            {
                hash1.GetFrequency(word);
            }
        }
    }

}