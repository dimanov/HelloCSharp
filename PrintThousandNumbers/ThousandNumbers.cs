/*
 Problem 17: This is a program that prints at the console the numbers from  1 to 1000 , each at a separate line.
 */

using System;

class ThousandNumbers
{
    static void Main()
    {
        int seqMembers = 1000;
        for (int n = 1; n <= seqMembers; n++)
        {
            Console.WriteLine(n);
        }
    }
}
