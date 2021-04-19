using System;

namespace Prime.Models

{
  public class PrimeNumbers
  {
    public static void PrimeMethod(int n)
    {
// do not need return stmt since the method is void  
        // Create a boolean array
        // "prime[0..n]" and
        // initialize all entries
        // it as true. A value in
        // prime[i] will finally be
        // false if i is Not a
        // prime, else true.
 
        bool[] prime = new bool[n + 1];
// create bool array, all set to true
         for (int i = 0; i < n; i++)
        {
            Console.WriteLine("first bool " + i + " " + prime[i]);
        }
// for test only ^^^
        for (int i = 0; i < n; i++)
        {
            prime[i] = true;
            Console.WriteLine("2nd bool " + i + " " + prime[i]);
        }
 // set all to true ^^^
        for (int p = 2; p * p <= n; p++)
        {
          Console.WriteLine("3rd bool " + p);
            // If prime[p] is not changed,
            // then it is a prime
// will iterate through and update each to false 
            if (prime[p] == true)
            {
                // Update all multiples of p
                for (int i = p * p; i <= n; i += p)
//this is how we progress to next number, i += p
                {
                Console.WriteLine("4th bool " + p + " " + prime[i]);
                    prime[i] = false;
                }
            }
        }
        // Print all prime numbers
        for (int i = 2; i <= n; i++)
        {
            if (prime[i] == true)
                Console.Write(i + " ");
        }
    }  
  }
}
//     Given a number, write a method that returns all of the prime numbers less than that number.

// This is a tricky problem and you should use the Sieve of Eratosthenes to solve it. Here's how the Sieve of Eratosthenes works to find a number up to a given number:

// static list
// static method 
// create a loop that adds all numbers up to user input to list
// Create a list of numbers from 2 through n: 2, 3, 4, ..., number.

// Initially, let prime equal 2, the first prime number.
// use remove() to remove numbers divisible by 2 
// Starting from prime, remove all multiples of prime from the list.
// Increment prime by 1.
// When you reach number, all the remaining numbers in the list are primes.

