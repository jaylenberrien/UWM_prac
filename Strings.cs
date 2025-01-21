// Excercise 1

//without LINQ then with LINQ

//given a string of characters: 
//1: See if a word occurs in the string of characters
//2: alphabetize the letters
//3: Reverse the letters in a given word



using System;
using System.Linq;

namespace UWM_prac;


class Strings
{

    string listOfChars = "khfallifeloverjkocsaohe";

    //NO LINQ
    public Boolean WordSearch()
    {
        string guessWord = "khalifa";
        int letterChecker = 0;

        for(int i = 0; i < listOfChars.Count(); i++)
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


    static void Main(string[] args)
    {
        Strings test2 = new Strings();

        test2.WordSearch();
    }

}