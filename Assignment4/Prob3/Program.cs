/*
Author: Torin Tashima
Date:   October 26, 2019
CTEC 135: Microsoft Software Development with C#

Module 5, Programming Assignment 4, Problem 3

    Dictionaries

- Put all your code in main. 
- Dictionary use
    - declare a dictionary and initialization it to create 3 entries:
        (1, "one"), (2, "two"), and (3, "three"). Use a combination of
        initialization syntax, Add() and [] in your initialization code.
    - add an additional entry: (99, "ninety-nine")
    - show use of enumerator to see all entries. Print both the key and value
    - reassign the value of 99 to "99" using indexing notation
    - print the new value using indexing notation
    - remove the 2 item and enumerate over the whole dictionary to show it's
        gone

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration and initialization of dictionary
            Dictionary<int, string> Numerals = new Dictionary<int, string>() { { 1, "one" } };
            Numerals.Add(2, "two");
            Numerals[3] = "three";
            Numerals[99] = "ninety-nine";

            // use of enumerator to print keys and values
            Console.WriteLine("Dictionary entries:");
            foreach (KeyValuePair<int, string> entry in Numerals)
            {
                Console.WriteLine("\t{0} - {1}", entry.Key, entry.Value);
            }
            Console.WriteLine();

            // reassign Numerals[99]'s value to "99" and print new value
            Numerals[99] = "99";
            Console.WriteLine("Numerals[99]'s new value: {0}", Numerals[99]);
            Console.WriteLine();

            // remove Numerals[2] and enumerate to show it's gone
            Numerals.Remove(2);
            Console.WriteLine("Dictionary entries (without 2):");
            foreach (KeyValuePair<int, string> entry in Numerals)
            {
                Console.WriteLine("\t{0} - {1}", entry.Key, entry.Value);
            }
            Console.WriteLine();
        }
    }
}
