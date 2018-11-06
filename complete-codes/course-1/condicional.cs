/* Created on 04 November 2018
@author: vinimmelo
Description: Testing conditionals */

using System;

public class Programa {

  public static void Main(string[] args)
  {
      int idade = 20;
      int quantidadePessoas = 3;

      if (idade >= 18) {
        Console.WriteLine("Você tem mais de 18 anos.");
        Console.WriteLine("Seja bem vindo!");
      } else {
        if (quantidadePessoas > 1 ){
          Console.WriteLine("Você não tem mais de 18 anos, mas está acompanhado, por isso pode entrar!");
        }
        else {
          Console.WriteLine("Infelizmente você não pode entrar.");
        }
      }

  }
}
