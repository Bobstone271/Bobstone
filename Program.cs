// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        //create array for months of the year
        string[] months = new string[12]
      {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};

        //initialise prng with a time-dependent default seed value
        Random rnd = new Random();

        //will create a number between 1 and 12
        int month = rnd.Next(1, 13);

        //output the random month name
        Console.WriteLine("Month is {0}", months[month - 1]);
        RangeTest();
        RoundTest();
        TruncateTest();
        GetLengthOfString("Ismaeel Ahmed");
        GetCharOfString("Ismaeel Ahmed", 4);
    
    }
    public static void RangeTest()
    {
        IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);

        foreach (int num in squares)
        {
            Console.WriteLine(num);
        }
    }

    public static void RoundTest()
    {
        float OriginalNumber1 = 1.23f;
        float OriginalNumber2 = 3.15f;
        float OriginalNumber3 = 1.9f;

        float roundedNumber1 = (float)Math.Ceiling(OriginalNumber1);
        float roundedNumber2 = (float)Math.Round(OriginalNumber2, 1);
        float roundedNumber3 = (float)Math.Floor(OriginalNumber3);

        Console.WriteLine("roundedNumber1 is " + roundedNumber1);
        Console.WriteLine("roundedNumber2 is " + roundedNumber2);
        Console.WriteLine("roundedNumber3 is " + roundedNumber3);

    }

    public static void TruncateTest()
    {

        decimal decimalNumber; 
        
        decimalNumber = 32.7865m;

        Console.Write(Math.Truncate(decimalNumber));
        
        decimalNumber = -32.9012m;

        Console.WriteLine(Math.Truncate(decimalNumber));
    }

    public static void GetLengthOfString(string str)
    {
        int length;
        length = str.Length;
        Console.WriteLine("{0} is {1} characters long", str , length);
    }
    public static void GetCharOfString(string str, int i)
    {
        char singleletter;

        singleletter = str[i];
        
        Console.WriteLine("Character {0} of {1} is {2}", i,str , singleletter);

    }
    public static void RemovePartString(string str, int a)
    {
        string month = "January";
        string subString;
        int startpoPos = 3;
        int howMany = 2;

        subString = month.Substring(startpoPos, howMany);
        Console.WriteLine("Substring is {0}", subString , a);


    }


}
