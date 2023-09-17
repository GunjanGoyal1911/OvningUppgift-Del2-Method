using System;
using System.Threading.Channels;
using static System.Formats.Asn1.AsnWriter;

namespace OvningMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             //**************** Program 1:: ****************

             Console.WriteLine("Please enter a number::");
             int number = Convert.ToInt32(Console.ReadLine());
             CheckEvenOrOdd(number);

             //**************** Program 2:: ****************

             Console.WriteLine("Please enter your age::");
             int age = Convert.ToInt32(Console.ReadLine());
             DetermineAgeBracket(age);

             //**************** Program 3:: ****************

             Console.WriteLine("Please enter your score");
             int score = Convert.ToInt32(Console.ReadLine());
             AssignGrade(score);

            //**************** Program 4:: ****************

            Console.WriteLine("Please enter three numbers::");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            GetMaxOfThree(number1, number2, number3);

            //**************** Program 5:: ****************

            Console.WriteLine("Please enter a number::");
            int number = Convert.ToInt32(Console.ReadLine());
            DetermineNumberType(number);

            //**************** Program 6::****************

            Console.WriteLine("Please enter the purchase amount::");
            double amount= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter how much discount you got on your shopping");
            double discount = Convert.ToDouble(Console.ReadLine());
            GetDiscountedAmount(amount,discount);

            //**************** Program 7:: ****************

            Console.WriteLine("Please enter the number of weekdays");
            int weekDays = Convert.ToInt32(Console.ReadLine());
            PrintDayOfWeek(weekDays);


            //**************** Program 8:: ****************

            Console.WriteLine("Please enter the password::");
            string userPassword= Console.ReadLine();
            CheckPassword(userPassword);*/

            //**************** Program 9:: ****************

            Console.WriteLine("Do you want to convert the temperature into celcius then write 'Yes' otherwise 'NO'");
            string choice= Console.ReadLine();
            Console.WriteLine("Please enter the temperature::");
            double temp = Convert.ToDouble(Console.ReadLine());
            PerformTemperatureConversion(temp, choice); 
        }

        //#################### Method  CheckEvenOrOdd #################
        static void CheckEvenOrOdd(int num)
        {
            if(num%2==0)
                Console.WriteLine($"{num} is a even number");
            else
            {
                Console.WriteLine($"{num} is a odd number");
            }
        }


        //#################### Method  DetermineAgeBracket #################
        static void DetermineAgeBracket(int age)
        {
            if (age < 13)
            {
                Console.WriteLine("You are a child");
            }
            else if(age>=13 && age <=19)
            {
                Console.WriteLine("You are a teenager");
            }
            else
            {
                Console.WriteLine("You are an adult.");
            }
        }

        //#################### Method  AssignGrade #################

        static void AssignGrade(int score)
        {
            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("Your grade is :: A");
            }
            else if (score >= 80 && score <= 89)
            {
                Console.WriteLine("Your grade is :: B");

            }
            else if (score >= 70 && score <= 79)
            {
                Console.WriteLine("Your grade is :: C");
            }
            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine("Your grade is :: D");
            }
            else
            {
                Console.WriteLine("Your garde is :: F");
            }
        }

        //################ Maximum of Three: ##############################
        static int FindMax(int number1, int number2, int number3)
        {
            if (number1 >= number2 && number1 >= number3)
            {
                return number1;
                
            }
            else if (number2 >= number3 && number2 >= number1)
            {
                return number2;
                
            }
            else
            {
                return number3;
                
            }
        }

        static void GetMaxOfThree(int num1, int num2, int num3)
        {
            int maxNumber= FindMax(num1, num2, num3);
            Console.WriteLine($"Maximum number is {maxNumber}");
        }


        //################# CheckNumberType ##############################

        static string CheckNumberType(int number)
        {
            if (number > 0)
                return "positive";               
            else if (number < 0)
                return "Negative";               
            else
                return "Zero";
        }

        static void DetermineNumberType(int number)
        {
            //string findNumberStatus = CheckNumberType(number);
            Console.WriteLine($"The number you have entered is {CheckNumberType(number)} ");
        }

        //#################### GetDiscountedAmount ##########################

       static double CalculateDiscount(double amount, double discount)
        {
            double DiscountAmount = amount - (amount * discount / 100);
            return DiscountAmount;
        }

       
        static void GetDiscountedAmount(double amount, double discount)
        {
            Console.WriteLine($"The final amount after discount is {CalculateDiscount(amount, discount)}");
        }

        //#################### GetDayOfWeek ##########################

        static string GetDayOfWeek(int numberOfWeekDays)
        {
            if (numberOfWeekDays == 1) return "Monday";
            else if (numberOfWeekDays == 2) return "Tuesday";
            else if (numberOfWeekDays == 3) return "Wednesday";
            else if (numberOfWeekDays == 4) return "Thursday";
            else if (numberOfWeekDays == 5) return "Friday";
            else if (numberOfWeekDays == 6) return "Saturday";
            else if (numberOfWeekDays == 7) return "Sunday";
            else return "The number is out of range";
        }

        static void PrintDayOfWeek(int weekDaysNumber)
        {
            Console.WriteLine($"It is {GetDayOfWeek(weekDaysNumber)} today.");
        }

        //#################### IsValidPassword ##########################
        static bool IsValidPassword(string userPassword)
        {
            string predefinrPassword = "cloud23";
            if (predefinrPassword == userPassword)
                return true;
            else
                return false;
        }

         static void CheckPassword(string userInput)
        {
            if (IsValidPassword(userInput))
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("Access denied");
            }
        }


        //#################### ConvertTemperature ##########################

        static void PerformTemperatureConversion(double temp, string choice)
        {
           if (choice == "yes")
            {
                Console.WriteLine($"Coverted temperature is: {ConvertTemperature(temp, true)} degree celcius"); 
            }
            else
                Console.WriteLine($"Coverted temperature is: {ConvertTemperature(temp, false)} fahrenhiet");
        }

        static double ConvertTemperature(double temp, bool toCelsius)
        {
            if(toCelsius)
            {
                return (temp - 32) * 5 / 9;
            }
            else
                return temp * 9 / 5 + 32;
        }



    }
}