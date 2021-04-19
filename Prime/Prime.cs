using System;
using Prime.Models;

namespace Prime 
{
  public class PrimeProgram
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number to find all prime numbers below or including the number:");
      string userInput = Console.ReadLine();
      int input = int.Parse(userInput);

      Console.WriteLine("Here are the prime numbers");
      Console.WriteLine("smaller than or equal to " + input);
      PrimeNumbers.PrimeMethod(input);
    }   
  }
}