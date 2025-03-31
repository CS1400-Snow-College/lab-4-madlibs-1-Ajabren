// See https://aka.ms/new-console-template for more information
using System;

class MadLibs
{
    static void Main()
    {
// The Greeting and explaination of the program
Console.WriteLine("Welcome to Mad Libs! This is a game, where you will be asked to provide different types of words (adjectives, nouns, or verbs, etc), and we'll build a funny story for you!");
Console.WriteLine("Let's get started!\n");

// The OG story made neat
        string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. " +
                               "Usually, you go to some place that is near a/an (noun) or up on a/an (noun). " +
                               "A good vacation place is one where you can ride (plural noun) or play (game) or go hunting for (plural noun). " +
                               "I like to spend my time (verb ending in \"ing\") or (verb ending in \"ing\"). " +
                               "When parents go on a vacation, they spend their time eating three (plural noun) a day, " +
                               "and fathers play golf, and mothers sit around (verb ending in \"ing\") Last summer, my little brother fell in a/an (noun) " +
                               "and got poison (plant) all over his (part of the body) My family is going to go to (place) and I will practice (verb ending in \"ing\"). " +
                               "Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours " +
                               "every day all year making enough (plural noun) to pay for the vacation.";

        // This should hopefully split original story into words
        string[] storyWords = originalStory.Split(' ');
         string newStory = "";

        foreach (string word in storyWords)
        {
            // If the word has parentheses, it's a placeholder for user input
            if (word.StartsWith("(") && word.EndsWith(")"))
            {
                // Remove the parentheses to get the word type
                string wordType = word.Substring(1, word.Length - 2);
                
                // Check "a" or "an" based on vowel sounds
                string article = "a";
                if (IsVowel(wordType[0]))
                {
                    article = "an";
                }

                // Ask the word type
                Console.Write($"Please give me {article} {wordType}: ");
                string userInput = Console.ReadLine();

                newStory += userInput + " ";
            }
            else
            {
                // If it's not a placeholder, add the word as it is
                newStory += word + " ";
            }
        }
// Display the final Mad Libbed story
        Console.WriteLine("\nHere is your Mad Libs story:\n");
        Console.WriteLine(newStory);
    }

    // the quick fix system helped here
 private static bool IsVowel(char c)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        return Array.Exists(vowels, v => v == char.ToLower(c));
    }
}