using System;
namespace ExercicioIMC
{
  class Program
  {
    static void Main(string[] args)
    {
      Pessoa pessoa = new Pessoa();
      Console.WriteLine("===================================");
      Console.WriteLine("Digite seu peso:");
      pessoa.peso = double.Parse(Console.ReadLine());

      Console.WriteLine("Digite sua altura:");
      pessoa.altura = double.Parse(Console.ReadLine());
      // pessoa.peso = 80;
      // pessoa.altura = 1.80;  //1,80

      pessoa.mensagem();
      Console.WriteLine("===================================");
      Console.ReadKey();
    }
  }
}

