namespace c_6;
  using System;
    using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
         CultureInfo CI = CultureInfo.InvariantCulture;
         int N;
         System.Console.Write("Quantos números você vai digitar?");
         N= int.Parse(Console.ReadLine());
         double[] vet = new double[N];

         for (int i=0; i < N; i++)
         {
            System.Console.Write("Digite um número:");
            vet[i]=Double.Parse(Console.ReadLine(),CI);
         }

            System.Console.WriteLine();
            System.Console.WriteLine("Numeros Digitados:");

            for (int i =0; i<N ; i++)
            {
                 System.Console.WriteLine(vet[i].ToString("F1",CI));
            }
    }
}
