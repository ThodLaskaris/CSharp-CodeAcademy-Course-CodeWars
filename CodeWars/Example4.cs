using System;
using System.Collections.Generic; // Για List<string>
using System.Linq; // Για .All()

public class Example4
{
/*

Vicky is quite the small wonder. Most people don't even realize she's not a real girl, but a robot living amongst us. Sure, if you stick around her home for a while you might see her creator open up her back and make a few tweaks and even see her recharge in the closet instead of sleeping in a bed.

In this kata, we're going to help Vicky keep track of the words she's learning.

Write a function, learnWord(word) ( LearnWord(word) in C# ) which is a method of the Robot object. The function should report back whether the word is now stored, or if she already knew the word.

Example:

Robot vicky = new Robot();
vicky.LearnWord("hello"); // "Thank you for teaching me hello"
vicky.LearnWord("abc"); // "Thank you for teaching me abc"
vicky.LearnWord("hello"); // "I already know the word hello"
vicky.LearnWord("wow!"); // "I do not understand the input"
Case shouldn't matter. Only alpha characters are valid. There's also a little trick here. Enjoy!


*/


  public class Robot
  {
    // Λιστα για αποθηκευση λεξεων που ξερει.
    private List<string> learnedWords = new List<string>();
    public string LearnWord(string word)
    {
      // Ελεγχουμε αν η λεξη περιεχει μονο γραμματα αλλιως επιστρεφουμε μηνυμα λαθους
      if (!word.All(char.IsLetter))
      {
        return "I do not understand the input";
      }

      // μετατρεπουμε την λεξη σε lowercase για ελεγχο αν ειναι στον πινακα
      string lowerWord = word.ToLower(); // ← Μετατρέπουμε σε lowercase

      // ελεγχουμε αν υπαρχει η λεξη στην λιστα , επιστρεφουμε επιτυχια αλλιως αποτυχια.
      if (learnedWords.Contains(lowerWord)) // 
      {
        return $"I already know the word {word}";
      }
      else
      {
        learnedWords.Add(lowerWord); // ← Αποθηκεύουμε το lowercase
        return $"Thank you for teaching me {word}";
      }
    }
  }
}