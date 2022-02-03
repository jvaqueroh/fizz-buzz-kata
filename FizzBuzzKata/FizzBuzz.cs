using System;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public static string NumberToText(int number)
        {
            if(number.Equals(1))
                return "one";
            if(number.Equals(2))
                return "two";
            if(number.Equals(3))
                return "FIZZ";
            return "four";
        }
    }
}