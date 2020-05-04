﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Class10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Looping through a list with foreach
            var list5 = new List<int> { 1, 2, 4, 8, 16, 32 };
            Console.WriteLine("With a foreach...");
            foreach (var number in list5)
            {
                Console.WriteLine(number);
            }

            // Looping through a list with for
            Console.WriteLine("With a for...");
            for (int i = 0; i < list5.Count; i++)
            {
                var number = list5[i];
                Console.WriteLine(number);
            }
            
            return;

            // List methodsssssssssssssssssssssssssssssss
            var list4 = new List<int>();
            list4.Add(57);
            list4.Remove(57); // list4.Clear(); list4.RemoveAt(0);
            Console.WriteLine(list4.Count);

            // Adding to my list
            List<int> list = new List<int>();
            Console.WriteLine($"List length = {list.Count}");
            list.Add(56); // list[0]
            Console.WriteLine($"List length = {list.Count}");
            list.Add(57); // list[1]
            Console.WriteLine($"List length = {list.Count}");
            list.Add(58); // list[2]
            Console.WriteLine($"List length = {list.Count}");

            // Retrieving values from my list
            list[0] = 200;
            Console.WriteLine($"list[0] = {list[0]}");

            // Why var?
            var crazyThing = new List<List<List<int[]>>>();

            // Short-hand
            List<int> list3 = new List<int> { 56, 57, 58 };

            // Medium-hand
            List<int> list2 = new List<int>();
            list2.Add(56);
            list2.Add(57);
            list2.Add(58);

            // Long-hand
            List<int> list1;
            list1 = new List<int>();
            list1.Add(56);
            list1.Add(57);
            list1.Add(58);

            // Declaring an array vs a list
            int[] myArray;
            List<int> myList;

            // Initializing an array vs a list
            myArray = new int[5];
            myList = new List<int>();
        }
    }
}