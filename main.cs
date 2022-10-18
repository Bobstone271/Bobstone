using System;

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
      Console.WriteLine("Month is {0}", months[month-1]);
    }
}