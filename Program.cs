﻿// See https://aka.ms/new-console-template for more information
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
 }
}       