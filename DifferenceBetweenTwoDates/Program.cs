using System;

namespace DifferenceBetweenTwoDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prevDate = new DateTime(2022, 1, 1);
            var today = DateTime.Now;
            var differenceBetweenDates=today - prevDate;
            System.Console.WriteLine(prevDate);
            System.Console.WriteLine(today);
            System.Console.WriteLine(differenceBetweenDates);
        }
    }
}
