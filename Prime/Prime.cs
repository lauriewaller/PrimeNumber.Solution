using System;
using Prime.Models;
using System.Collections.Generic;


namespace Prime 
{
  public class PrimeProgram
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number to find all prime numbers below or including the number:");
      int input = int.Parse(Console.ReadLine());

      Console.WriteLine(
          "Following are the prime numbers");
      Console.WriteLine("smaller than or equal to " + input);
      PrimeNumbers.PrimeMethod(input);

      
      
      // List<int> primeList = new List<int> {}; 
    
      // for (int index = 2; index <= 10; index++)
      // {
      //   primeList.Add(index);
      //   Console.WriteLine("index is: " + index);
      // }

      // for (int index = 0; index < primeList.Count; index++)
      // {
      //   Console.WriteLine("number is: " + primeList[index]);
      // }

      

 

      // foreach (int index in primeList) 
      // {
      // Console.WriteLine("Index is: ", primeList[index]);
      // }
    }   
  }
}