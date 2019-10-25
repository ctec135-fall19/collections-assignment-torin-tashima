/*
Author: Torin Tashima
Date:   October 26, 2019
CTEC 135: Microsoft Software Development with C#

Module 5, Programming Assignment 4, Problem 1

    Arrays and Lists

- Put all your code in main. 
- Regions
    - Simple array:
        - create an array of int of size 5
        - use a for loop to initialize it to the numbers 11 - 15
        - use a foreach loop to print out the values in the array
    - List<T>
        - create a list of int
        - use a for loop to initialize the list to the numbers 21 - 25
        - use a foreach loop to print out the values in the list
        - update the values in the list to 31 - 35 using indexing
        - repeat the print using a for loop and indexing

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array
            int[] ArrayOfInts = new int[5];

            // initialize array using for loop (values 11-15)
            for (int i = 0; i < ArrayOfInts.Length; i++)
            {
                ArrayOfInts[i] = i + 11;
            }

            // print out array using foreach loop
            Console.Write("ArrayOfInts: ");
            foreach (int num in ArrayOfInts)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            #endregion

            #region list
            List<int> ListOfInts = new List<int>();

            // initialize array using for loop (values 21-25)
            for (int i = 0; i < 5; i++)
            {
                ListOfInts.Add(i + 21);
            }

            // print out array using foreach loop
            Console.Write("ListOfInts: ");
            foreach (int num in ListOfInts)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();

            // update list via indexing (values 31-35)
            for (int i = 0; i < ListOfInts.Count; i++)
            {
                ListOfInts[i] += 10;
            }

            // print out updated array using for loop
            Console.Write("ListOfInts (updated): ");
            for (int i = 0; i < ListOfInts.Count; i++)
            {
                Console.Write("{0} ", ListOfInts[i]);
            }
            Console.WriteLine();
            #endregion
        }
    }
}
