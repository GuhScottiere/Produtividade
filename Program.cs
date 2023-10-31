namespace Produtividade;

class Program
{
    static void Main(string[] args)
    {
      // codigo realizado com base nas instruções do livro produtividade em c#
      // operadores de atribuição 

      Console.WriteLine(" valores iniciais das variaveis: ");
      int x = 10;
      int y = 5;
      Console.WriteLine($" X: {x} y: {y}");
      Console.WriteLine();

      Console.WriteLine("empregando operador de atribuição soma ");
       x+= y;
       Console.WriteLine($" X:{x} Y: {y}");
       Console.WriteLine();

       Console.WriteLine("Empregando operador de atribuição subtração");
       x -= y;
       Console.WriteLine($" X; {x} Y: {y}");
       Console.WriteLine();

       Console.WriteLine("Empregando operador de atribuição de multiplicação");
       x*=y;
       Console.WriteLine();

       Console.WriteLine("Operação de atribuição de divisão");
       x/=y;
       Console.WriteLine($" X:{x} y:{y}");
       Console.WriteLine();

    }
}
