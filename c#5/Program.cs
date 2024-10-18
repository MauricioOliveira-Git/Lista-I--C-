namespace c_5;
  using System;
    using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

         double salario1 , salario2;
         string nome1 , nome2;
         int idade;
         char sexo; 

         System.Console.WriteLine("Digite o nome da primeira pessoa: ");
         nome1=Console.ReadLine();

         System.Console.WriteLine("Digite o nome da segunda pessoa: ");
        nome2=Console.ReadLine();

         System.Console.WriteLine("Digite o salario da primeira pessoa: ");
         salario1=double.Parse(Console.ReadLine(),CI);

         System.Console.WriteLine("Digite o salario da segunda pessoa: ");
         salario2=double.Parse(Console.ReadLine(),CI);

        System.Console.WriteLine("Digite uma idade: ");
        idade=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite um sexo(F/M): ");
        sexo=char.Parse(Console.ReadLine());
         
         System.Console.WriteLine("Nome 1 = "+ nome1);
         System.Console.WriteLine("Nome 2= "+ nome2);
         System.Console.WriteLine("Salario 1= " + salario1.ToString("F2",CI));
         System.Console.WriteLine("Salario 2= " + salario2.ToString("F2",CI));
         System.Console.WriteLine("Idade = " + idade);
         System.Console.WriteLine("Sexo= " + sexo );
    }
}
