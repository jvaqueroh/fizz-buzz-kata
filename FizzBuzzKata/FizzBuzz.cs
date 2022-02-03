using System;

namespace FizzBuzzKata
{
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