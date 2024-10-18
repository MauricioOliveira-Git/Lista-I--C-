namespace c_;
  using System;
    using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
       int idade;
       double salario,altura;
       char sexo;
       string nome;
        CultureInfo CI =CultureInfo.InvariantCulture;
       idade= 20;
       salario= 4000.20;
       sexo = 'M';
       nome="Mauricio";

      System.Console.WriteLine("O funcionario "+nome + ",sexo "+ sexo +",ganha "+ salario.ToString("F2",CI)+" e tem "+idade +" anos ");
    }
}
