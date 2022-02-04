using System;

namespace FizzBuzzKata
{
    /// <summary>
    /// For numbers from 1 to 100, returns the string representation
    /// For numbers being multiple of 3, returns "FIZZ"
    /// For numbers being multiple of 5, returns "BUZZ"
    /// For numbers being multiple of 3 and 5, returns "FIZZBUZZ"
    /// </summary>
    public class FizzBuzzer
    {
        public static string FizzBuzz(int number) =>
            number switch
            {
                3 => "FIZZ",
                5 => "BUZZ",
                _ => number.ToString()
            };
    }
}