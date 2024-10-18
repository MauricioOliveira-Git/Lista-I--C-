namespace c_4;
  using System;
    using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        CultureInfo CI= CultureInfo.InvariantCulture;
        double x,y,resultado;
        x=5;
        y=2;
        resultado=x/y;
        System.Console.WriteLine(resultado);
    }
}
