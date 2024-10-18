namespace c_2;
    using System;
    using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
       CultureInfo CI=CultureInfo.InvariantCulture;
       double x;
       x=3.231;
       System.Console.WriteLine(x.ToString("F2",CI));
    }
}
