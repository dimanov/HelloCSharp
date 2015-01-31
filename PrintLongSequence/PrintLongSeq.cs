/*
Problem 16. This is a program that prints the first 1000 members of the sequence:  2, -3, 4, -5, 6, -7, …  
*/

using System;

class PrintLongSequence
{
    static void Main()
    {
        int seqNumber = 1;
        int diffNumber = -1;
        int seqMembers = 1000;
        for (int n = 0; n < seqMembers; ++n)
        {
            diffNumber = diffNumber * (-1);
            seqNumber = (Math.Abs((seqNumber)) + 1) * diffNumber;
            Console.Write(seqNumber);

            //Print ", " after the first 999 numbers
            if (n < (seqMembers - 1))
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
