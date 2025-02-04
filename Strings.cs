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
using System.Runtime.CompilerServices;

namespace UWM_prac;


class Strings
{

    string listOfChars = "khfallifeloverjkocsaohe";

    //NO LINQ
    public Boolean WordSearch()
    {
        Dictionary<char, int> charList = new Dictionary<char, int>();
        string guessWord = "life";
        

        foreach(char c in listOfChars)
        {
            
            if(charList.ContainsKey(c))
            {
                continue;
            }
            else
            {
                charList.Add(c, 0);
            }

            if(guessWord.Contains(c))
            {
                charList[c]++;
            }
            else
            {
                continue;
            }
            
        }

       //used to see all of the keys and their values
        foreach(var c in charList)
        {
            Console.Write(c);
        }
  
        return true;
    




       // we are going to try a more effecient version with a hash map 
    }
    
    public void WordSearchLINQ()
    {

     // we are going to try a more effecient version with a hash map 

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
        List<char> allLetters = listOfChars.ToList();
        var sortedLetters = allLetters.OrderBy(c => c);
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

    public void reverseStringLINQ()
    {
        string word = "superword";
        List<char> charList = new List<char>(word);
        // charList = word.ToList();
        charList.Reverse();
        Console.WriteLine(String.Join("", charList));

    }

    static void Main(string[] args)
    {
        Strings test2 = new Strings();

        // test2.WordSearch();
        // test2.Alphabetize();
        // test2.reverseString();

        // test2.AlphabetizeLINQ();
        // test2.reverseStringLINQ();
        test2.WordSearch();
    }

}
