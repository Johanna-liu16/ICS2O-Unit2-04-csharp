// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math

using System;

class Program {
  public static void Main(string[] args)
    {
        // This function states user's address input.
        string height;
        int bases;

        Console.WriteLine("This program will retell the area of a triangle.");
        Console.WriteLine("");

        Console.WriteLine("Enter height of the triangle: ")
        height = Console.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter base of teh triangle: ")
        bases = Console.ToInt32(Console.ReadLine());

              Console.WriteLine("");
        Console.WriteLine("The area is is: " + (height * bases) /2  + "cm².");
        Console.WriteLine("\nDone.");
    }
}
      