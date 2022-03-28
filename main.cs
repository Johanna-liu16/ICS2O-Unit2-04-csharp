// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function states user's address input.
        int triangleHeight;
        int triangleBase;

        Console.WriteLine("This program will retell the area of a triangle.");
        Console.WriteLine("");
        Console.Write("Enter height of the triangle: ");
        triangleHeight = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter base of the triangle: ");
        triangleBase = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("The area is: " + (triangleHeight * triangleBase) /2 + " cm².");
        Console.WriteLine("\nDone.");
    }
}