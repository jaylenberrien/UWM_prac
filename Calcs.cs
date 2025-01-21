using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security;

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
        5,2,2,2,3,4,5,7
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

    public void SumNum()
    {
        int sum = 0;
        foreach(int i in numList)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }

    public void Median()
    {
        if(numList.Count % 2 > 0)
        {
            int medianIndex = (numList.Count - 1) / 2;
            Console.WriteLine(numList[medianIndex]);    
        }
        else if(numList.Count % 2 == 0)
        {
            int medianNum1 = (numList.Count / 2) + 1;
            int medianNum2 = numList.Count / 2;
            int median = medianNum1 + medianNum2 / 2;
            Console.WriteLine(median);
        };
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

    // static void Main(string[] args)
    // {
    //     Calculations test = new Calculations();
        
    //     // test.AverageNum();
    //     // test.SumNum();
    //     // test.Median();
    //     test.Maximum();
    // }
    
};




