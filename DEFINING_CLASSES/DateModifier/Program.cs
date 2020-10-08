using System;

namespace DateModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();
            int result = dateModifier.GetDaysDiffrence(startDate, endDate);


            Console.WriteLine(result);
            
        }
    }
}
