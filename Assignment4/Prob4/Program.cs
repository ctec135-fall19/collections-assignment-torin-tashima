/*
Author: Torin Tashima
Date:   October 26, 2019
CTEC 135: Microsoft Software Development with C#

Module 5, Programming Assignment 4, Problem 4

    Dictionaries

- Put all your code in main. 
- LinkedList use
    - Demonstrate use of constructor taking an IEnumerable object. Create a
        string array having the first 5-10 words of your favorite nursery rhyme.
        Use it as the argument when constructing the LinkedList object.
    - Print out the rhyme on a single line.
    - The traditional way to walk a linked list is to start at the head, process
        the node, then set the node variable to the next node in the list.
        Create a node variable and walk the list to print out the values.
        The line printed should be the same as the one above.
    - Remove a word from the middle of the list. Print the list on a single
        line to demonstrate this
    - Add the word back in and print the list again to demonstrate.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize string array
            string[] lyrics = { "The", "World", "Has", "Turned",
                "And", "Left", "Me", "Here" };

            // declare and initialize linked list with string as an argument
            LinkedList<string> lyricList = new LinkedList<string>(lyrics);

            // print lyrics on single line
            foreach (string lyric in lyricList)
            {
                Console.Write("{0} ", lyric);
            }
            Console.WriteLine();

            // print lyrics by walking the linked list
            LinkedListNode<string> node = lyricList.First;
            while (node != null)
            {
                Console.Write("{0} ", node.Value);
                node = node.Next;
            }
            Console.WriteLine();

            // remove a word and print updated lyrics
            lyricList.Remove("Has");

            node = lyricList.First;
            while (node != null)
            {
                Console.Write("{0} ", node.Value);
                node = node.Next;
            }
            Console.WriteLine();

            // add word back in and print lyrics again
            node = lyricList.First;
            node = node.Next;
            lyricList.AddAfter(node, "Has");

            node = lyricList.First;
            while (node != null)
            {
                Console.Write("{0} ", node.Value);
                node = node.Next;
            }
            Console.WriteLine();
        }
    }
}
