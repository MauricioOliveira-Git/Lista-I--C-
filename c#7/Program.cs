namespace c_7;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Quantas linhas ira ter a matriz?");
        int M=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Quantas colunas ira ter a matriz?");
        int N = int.Parse(Console.ReadLine());

    int[,] matriz = new int [M,N];
        for (int i=0; i<M; i++)
        {
        for (int j=0;j<N;j++)
        {
            System.Console.Write($"Elemento[{i},{j}]:");
            matriz[i,j]=int.Parse(Console.ReadLine());
        }
     }
     System.Console.WriteLine();
     System.Console.WriteLine("Matriz Digitada");
     for (int i=0; i<M;i++){
        for (int j=0; j<N;j++){
            System.Console.Write(matriz[i,j]+"");
        }
        System.Console.WriteLine();
     }
    }
}
