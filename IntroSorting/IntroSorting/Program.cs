﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroSorting
{
//    About the Challenges
//The challenges will describe some topic and then ask you to code a solution.As you progress through the challenges, you will learn some important concepts in algorithms.In each challenge, you will receive input on STDIN and you will need to print the correct output to STDOUT.

//For many challenges, helper methods(like an array) will be provided for you to process the input into a useful format.You can use these methods to get started with your program, or you can write your own input methods if you want.Your code just needs to print the right output to each test case.


//Sample Challenge
//This is a simple challenge to get things started.Given a sorted array () and a number(), can you print the index location of  in the array?

//The next section describes the input format.You can often skip it, if you are using included methods.

//Input Format
//There will be three lines of input:

// - the value that has to be searched.
// - the size of the array.
// -  numbers that make up the array.
//Output Format
//Output the index of  in the array.

//The next section describes the constraints and ranges of the input.You should check this section to know the range of the input.

//Constraints

//It is guaranteed that  will occur in  exactly once.
//This "sample" shows the first input test case. It is often useful to go through the sample to understand a challenge.

//Sample Input

//4
//6
//1 4 5 7 9 12
//Sample Output

//1
//Explanation
//.The value  is the nd element in the array, but its index is  since array indices start from , so the answer is .
    class Program
    {
        static void Main(string[] args)
        {
            int index = Convert.ToInt32(Console.ReadLine());
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int [size];

            string elements = Console.ReadLine();
            string[] split = elements.Split(' ');

            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(split[i]);

                if (arr[i]==index)
                {
                    Console.WriteLine(i);
                }
            }
            

            Console.ReadKey();
        }
    }
}
