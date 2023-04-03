// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] words = { "kaş", "laf", "sopa", "araba", "aşk", "fal", "posa" };
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        foreach (string word in words)
        {
            // Sort the characters in the word
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);

            // Add the word to the list of anagrams for the sorted characters
            if (!anagrams.ContainsKey(sorted))
            {
                anagrams[sorted] = new List<string>();
            }
            anagrams[sorted].Add(word);
        }

        // Print out the groups of anagrams
        foreach (List<string> group in anagrams.Values)
        {
            foreach (string word in group)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }
}

