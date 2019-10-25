/*
Author: Torin Tashima
Date:   October 26, 2019
CTEC 135: Microsoft Software Development with C#

Module 5, Programming Assignment 4, Problem 2

    Stacks and Queues

- Put all your code in main.
- Regions
    - Stack
        - declare and initialize a stack with the numbers 1 - 5 using
            initialization syntax.
        - demonstrate use of the enumerator to print out the members in the
            stack, i.e. write a foreach loop
        - print a peek at the top member in the stack
        - write a loop that pops the elements off of the stack and prints each
    - Queue
        - declare a queue
        - initialize the queue with the numbers 1-5 using a for loop.
        - demonstrate use of the enumerator to print out the members in the
            queue, i.e. write a foreach loop
        - print a peek at the top member in the stack
        - write a loop that dequeues the elements from the stack and prints
            each

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region stack
            // initialization (values 1-5)
            Stack<int> StackOfInts = new Stack<int>(new[] { 1, 2, 3, 4, 5 });

            // print out stack integers
            Console.Write("StackOfInts: ");
            foreach (int num in StackOfInts)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();

            // print out peek of stack
            Console.WriteLine("\tPeek: {0}", StackOfInts.Peek());

            // pop stack members and print their values
            Console.Write("\tPopped: ");
            while (StackOfInts.Count > 0)
            {
                int num = StackOfInts.Pop();
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region queue
            // queue declared
            Queue<int> QueueOfInts = new Queue<int>();

            // initialization (values 1-5)
            for (int i = 0; i < 5; i++)
            {
                QueueOfInts.Enqueue(i + 1);
            }

            // print out queue integers
            Console.Write("QueueOfInts: ");
            foreach (int num in QueueOfInts)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();

            // print out peek of queue
            Console.WriteLine("\tPeek: {0}", QueueOfInts.Peek());

            // dequeue members and print their values
            Console.Write("\tDequeued: ");
            while (QueueOfInts.Count > 0)
            {
                int num = QueueOfInts.Dequeue();
                Console.Write("{0} ", num);
            }
            #endregion
        }
    }
}
