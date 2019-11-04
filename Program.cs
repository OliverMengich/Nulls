using System;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<DateTime> date = null; //
            System.Console.WriteLine(date);
              

              System.Console.WriteLine("Get Value or default" + date.GetValueOrDefault());
              System.Console.WriteLine("Has value " +date.HasValue);
              System.Console.WriteLine(date.Value);

        }

    }
}
