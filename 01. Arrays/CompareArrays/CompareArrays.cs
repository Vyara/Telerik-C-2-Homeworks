﻿//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

using System;



class CompareArrays
{
    static void Main()
    {
        string str;
        int firstLenght;
        int secondLenght;

        //asks for the lenght of the first array
        do
        {
            Console.Write("Please enter a lenght for the first array: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out firstLenght));

        //creates first array with given lenght
        int[] firstArray = new int[firstLenght];

        //asks for first array inputs and initializes array accordingly(inputs must be valid)
        for (int i = 0; i < firstLenght; i++)
        {
            Console.Write("Please enter integer element {0} of the first array: ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("-------------------------------------------------------------");

        //asks for the lenght of the second array
        do
        {
            Console.Write("Please enter a lenght for the second array: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out secondLenght));

        //creates second array with given lenght
        int[] secondArray = new int[secondLenght];

        //asks for second array inputs and initializes array accordingly(inputs must be valid)
        for (int i = 0; i < secondLenght; i++)
        {
            Console.Write("Please enter integer element {0} of the second array: ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("-------------------------------------------------------------");

        //compares the lenghts of both arrays- not equal if lenghts are different sizes
        if (firstLenght != secondLenght)
        {
            Console.WriteLine("First array has {0} elements, second array has {1} elements ==> arrays are not equal.", firstLenght, secondLenght);
        }

        //if lenghts are equal, compares arrays element by element
        else
        {
            bool areEqual = true;
            for (int i = 0; i < firstLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    continue;
                }
                else
                {
                    areEqual = false;
                    break;
                }
            }

            //prints result 
            Console.WriteLine("Arrays are{0} equal.", areEqual ? "" : " NOT");
        }

    }
}

