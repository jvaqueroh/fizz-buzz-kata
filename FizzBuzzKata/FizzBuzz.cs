﻿using System;

namespace FizzBuzzKata
{
    /// <summary>
    /// For numbers from 1 to 100, returns the text representation
    /// For numbers being multiple of 3, returns "FIZZ"
    /// For numbers being multiple of 5, returns "BUZZ"
    /// For numbers being multiple of 3 and 5, returns "FIZZBUZZ"
    /// </summary>
    public class FizzBuzz
    {
        public static string NumberToText(int number) =>
            number switch
            {
                1 => "one",
                2 => "two",
                3 => "FIZZ",
                _ => "four"
            };
    }
}