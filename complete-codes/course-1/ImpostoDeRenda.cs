/* Created on 05 November 2018
@author: vinimmelo
Description: Income tax calculation */

using System;

public class Programa {

  public static void Main(string[] args)
  {
    double salario = 3300.00;

    if (salario < 1900.00)
      Console.WriteLine("Nenhuma dedução");
    else if (salario >= 1900.00 && salario <= 2800.00) {
      Console.WriteLine("Dedução de: R$ 142,00");
    }
    else if (salario > 2800.00 && salario <= 3751.00) {
      Console.WriteLine("Dedução de: R$ 350,00");
    }
    else if (salario > 3751.00) {
      Console.WriteLine("Dedução de: R$ 636,00");
    }
  }
}
