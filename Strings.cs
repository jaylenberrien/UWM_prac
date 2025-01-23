// Excercise 1

//without LINQ then with LINQ

//given a string of characters: 
//1: See if a word occurs in the string of characters
//2: alphabetize the letters
//3: Reverse the letters in a given word



using System;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace UWM_prac;


class Strings
{

    string listOfChars = "khfallifeloverjkocsaohe";

    //NO LINQ
    public Boolean WordSearch()
    {
        string guessWord = "love";
        int letterChecker = 0;

        for(int i = 0; i < listOfChars.Count() - 1; i++)
        {
            if(guessWord.Length == letterChecker)
            {   
                Console.WriteLine("true");
                return true;
            }

            if(guessWord[letterChecker] == listOfChars[i])
            {
                letterChecker++;
                continue;
            }
        }

        Console.WriteLine("false");
        return false; //does not output anything to console at all
                      //plan more carefully when starting problem and when making changes, understand exactly what you are doing and what you are trying to accomplish.
    }

    public void WordSearchLINQ()
    {
	    // we going to tyr
    }

    public void Alphabetize()
    {
        //convert string to array
        //use sort method on array
        //convert array back to string
        char[]chars = listOfChars.ToCharArray();
        Array.Sort(chars);
        String.Join("",chars);
        Console.WriteLine(chars);

        //decently effecient, it works though
    }

    public void AlphabetizeLINQ()
    {
        //not working yet
        List<char> sortedLetters = listOfChars.ToList();
        sortedLetters.OrderBy(c => c);
        string finalString = String.Join("", sortedLetters);
        Console.WriteLine(finalString);
    }

    public void reverseString()
    {
        //use a counter to iterate over the string backwards
        //add each char to an array
        //use join method to output it as a string

        string word = "superword";
        List<char> charHolder = new List<char>(); 
        for(int i = word.Count() - 1; i > -1; i--)
        {
            charHolder.Add(word[i]);
        };
          
        string reversedString = String.Join("", charHolder);
        Console.WriteLine(reversedString);
    } 

    static void Main(string[] args)
    {
        Strings test2 = new Strings();

        // test2.WordSearch();
        // test2.Alphabetize();
        // test2.reverseString();

        test2.AlphabetizeLINQ();
    }

}
