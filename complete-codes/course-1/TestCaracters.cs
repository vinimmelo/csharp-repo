/* Created on 04 November 2018
@author: vinimmelo
Description: Testing variables.*/

using System;


public class TestCaracters{

    public static void Main(string[] args)
    {
      Console.WriteLine("Teste 1");

      char primeiraLetra = (char)65;

      Console.WriteLine(primeiraLetra);

      char segundaLetra = (char) (primeiraLetra + 1);
      Console.WriteLine(segundaLetra);

      string alura = "Alura Cursos Online de Tecnologia ";
      Console.WriteLine(alura);

      alura += 2020;
      Console.WriteLine(alura);

      string alura2 = "Alura cursos online: " +
      "\n- .NET" +
      "\n- Java" +
      "\n- Python";
      Console.WriteLine(alura2);
    }

}
