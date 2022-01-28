using System;
 
namespace Desafios
{
  class Diferenca
  {
    static void Main(string[] args)
    {
      int A = int.Parse(Console.ReadLine());
      int B = int.Parse(Console.ReadLine());
      int C = int.Parse(Console.ReadLine());
      int D = int.Parse(Console.ReadLine());
 
      Console.WriteLine("DIFERENCA = {0:0}", (A * B - C * D));          
    }
  }   
}