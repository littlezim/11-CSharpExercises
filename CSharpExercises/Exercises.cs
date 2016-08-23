using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // C[reate a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name)
        {
            return "Hello " + name + "!";
        }
        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int number1, int number2)
        {
            number1 = 10;
            number2 = 12;
            return number1 + number2;
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static decimal Divide(decimal number1, decimal number2)
        {
            number1 = 10;
            number2 = 5;
            return number1 / number2;
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string FullName)
        {
            char[] delimiterChars = {' '};

            string[] FirstName = FullName.Split(delimiterChars);

            return FirstName[0];
        }
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string words1)
        {
            char[] chars = new char[words1.Length];
            for (int i = 0, j = words1.Length - 1; i <= j; i++, j--)
            {
                chars[i] = words1[j];
                chars[j] = words1[i];
            }
            return new string(chars);
        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string words)
        {
            char[] charArray = words.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */
         public static string PrintTimesTable(int number)
        {
            string string1 = "";
            string string2 = "";

            for (int i = 1; i <= 9; i++)
            {
                string1 += (number + " * " + i + " = " + number * i + "\r\n");

                string2 = (number + " * " + 10 + " = " + number * 10);
            }

            return string1 + string2;

        }
    // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double temperature)
        {
            double Fahrenheit = Math.Round(temperature * 9 / 5 - 459.67, 2);
            return Fahrenheit;
        }
    // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard(int[] numbers)
        {
            double Sum = 0;
            double Average = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Sum += numbers[i];
            }

            Average = Sum / numbers.Length;

            return Average;
        }
    // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
    public static double GetAverageEasy(int[] numbers)
        {
            double Average = numbers.Average();
            return Average;
        }
    // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
    /* e.g. Number: 8, Width: 8 should return
     * 88888888
     * 8888888
     * 888888
     * 88888
     * 8888
     * 888
     * 88
     * 8 */
     public static string DrawTriangle(int number, int width)
        {
            int i, j, k;
            string triangle = "";

            for (i = 1; i < width; i++)
            {
                for(j = 1;  j<= width - i; j++)
                {
                    
                }

                for (k = 1; k <= j; k++)
                {
                    triangle += number;
                }
                triangle += "\r\n";
            }

            triangle += number;

            return triangle;
        }
        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double distance, int hours, int minutes, int seconds)
        {
            string Speed = "";

            double TotalSeconds = (hours * 3600) + (minutes * 60) + seconds;

            Speed += Math.Round(distance / (TotalSeconds / 3600)) + "MPH";

            return Speed;
        }
        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char letter)
        {
            bool Answer;

            if(letter == 'a'|| letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Answer = true;
            }

            else
            {
                Answer = false;
            }

            return Answer;
        }
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char letter)
        {
            bool Answer;

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Answer = false;
            }

            else
            {
                Answer = true;
            }

            return Answer;
        }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture(int number)
        {
            int counter = 0;

            while (number != 1)
                {
                    if (number % 2 != 0)
                    {
                        number = number * 3 + 1;
                        counter += 1;
                    }

                    else
                    {
                        number = number / 2;
                        counter += 1;
                    }
                }

            return counter;
        }
        // 16.5 Create a method called GetOccurences that accepts two strings. The first string should represent a string of text, and the other should represent a single word. GetOccurrences should return the number of times that the given word appears in the string of text.
        public static int GetOccurences(string text, string word)
        {
            char[] delimiters = { ' ', '!' };
            int count = 0;
            string[] SubStrings = text.Split(delimiters);

            foreach(string StringWords in SubStrings)
            {
                if(StringWords == word)
                {
                    count += 1;
                }
            }

            return count;
        }
        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static Array GetNext7Days(DateTime Date)
        {
            DateTime[] Next7Days = new DateTime[7];

            for(int i = 0; i < 7; i++)
            {
                Next7Days[i] = Date.AddDays(i);
            }
            return Next7Days;
        }
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsInLeapYear(DateTime Date)
        {
            bool answer;
            int year = Date.Year;
            bool LeapYear = true;

            if((LeapYear == (year % 4 == 0) && (LeapYear == (year % 100 != 0))) || (LeapYear == (year % 100 == 0) && LeapYear == (year % 400 == 0)))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            return answer;
        }
        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static decimal MortgageCalculator(decimal LoanBalance, decimal InterestRate, int LoanTerm, int PaymentPeriod)
        {
            decimal NumberOfPayments = LoanTerm * PaymentPeriod;
            decimal MonthlyInterestRate = (InterestRate / 100) / PaymentPeriod;
            decimal CompoundedInterestRate = (decimal)Math.Pow((double)(1 + MonthlyInterestRate), (double)NumberOfPayments);
            decimal InterestQuotient = (MonthlyInterestRate * CompoundedInterestRate) / (CompoundedInterestRate - 1);
            decimal MonthlyPayment = Math.Round((LoanBalance * InterestQuotient) * 100) / 100;

            return MonthlyPayment;


        }
        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */
         public static string DuckGoose(int Number)
        {
            string Duck = "Duck";
            string Goose = "Goose";
            string Everything = "";
            int count = 0;

            for(int i = 1; i <= Number; i++)
            {
                if((i % 3 == 0) && (i % 5 == 0))
                {
                    Everything += (Duck + Goose);
                    count += 1;
                }
                else if(i % 3 == 0)
                {
                    Everything += Duck;
                    count += 1;
                }
                else if(i % 5 == 0)
                {
                    Everything += Goose;
                    count += 1;
                }
                else
                {
                    Everything += i;
                    count += 1;
                }

                if(i < Number)
                {
                    Everything += Environment.NewLine;
                }
            }

            return Everything;

        }
        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}