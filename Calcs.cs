using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;

// Exercise 2

//without LINQ, then with LINQ
//given a list of numbers:

//Average
//Sum
//Median
//Maximum

// pseudocode first
// have a reason for every change you are making

namespace UWM_prac;
class Calculations
{
    List<int> numList = new List<int>()
    {
        5,2,2,3,4,5,7,8
    };

    //Without LINQ

    public void AverageNum()
    {   
        int listLen = numList.Count;
        int sum = 0;
        foreach(int i in numList)
        {
            sum += i;
        }   
        
        Console.WriteLine(sum / listLen);
    }

    public void AverageNumLINQ()
    {
        //literally just use the average linq method
        //explicitly cast the int type onto the answer that we get in case we need it as int
        //you can implicit cast from smaller to larger data type, you have to use explicit for the opposite
         
         double average = numList.Average();
         int intAverage = (int) average;
         Console.WriteLine(intAverage);
    }

    public void SumNum()
    {
        int sum = 0;
        foreach(int i in numList)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }

    public void sumNumLINQ()
    {
        //same thing as last one
        Console.WriteLine(numList.Sum());
    }

    public void Median()
    {
        numList.Sort();
        if(numList.Count % 2 > 0)
        {
            int medianIndex = (numList.Count - 1) / 2;
            Console.WriteLine(numList[medianIndex]);    
        }
        else if(numList.Count % 2 == 0)
        {
            int medianNum1 = (numList.Count / 2) + 1;
            int medianNum2 = numList.Count / 2;
            float median = (medianNum1 + medianNum2) / 2f;
            Console.WriteLine(median);
        };
    }

    public void MedianLINQ()
    {
        //use LINQ Method to sort
        //use element at to pull out element at the index of the median if list count is odd
        //if list count is even we can take the middle indexs and average them

        numList.OrderBy(num => num);
        if(numList.Count % 2 > 0)
        {
            Console.WriteLine(numList.ElementAt((numList.Count - 1)/2));
        }
        else if(numList.Count % 2 == 0)
        {
            int medianNum1 = (numList.Count / 2) + 1;
            int medianNum2 = numList.Count / 2;
            float median = (medianNum1 + medianNum2) /2f;
            Console.WriteLine(median);
        }

    }

    public void Maximum()
    {
    
        Stack<int> currentLargest = new Stack<int>();
        currentLargest.Push(numList[0]);
        for(int i = 1; i < numList.Count(); i++)
        {
            if(numList[i] < currentLargest.Peek())
            {
                continue;
            }
            else if(numList[i] >= currentLargest.Peek())
            {
                currentLargest.Push(numList[i]);
            }
        };

        Console.WriteLine(currentLargest.Peek());
    }

    public void MaximumLINQ()
    {
        //use LINQ Method for Max

        Console.WriteLine(numList.Max());

    }

    static void Main(string[] args)
    {
        Calculations test = new Calculations();
        
        // test.AverageNum();
        // test.SumNum();
        // test.Median();
        // test.Maximum();
        // test.AverageNumLINQ();
        // test.sumNumLINQ();
        // test.MedianLINQ();
        // test.MaximumLINQ();
    }
    
};




