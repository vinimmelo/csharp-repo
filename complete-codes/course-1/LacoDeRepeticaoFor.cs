/* Created on 06 November 2018
@author: vinimmelo
Description: Practice of repetition loop for */

using System;

public class Program
{

  public static void Main(string[] args)
  {

    for (int i = 1; i <= 10; i++)
    {

      for(int x = 1; x <= 10; x++)
      {
        Console.Write(x * i + "\t");
      }
      Console.WriteLine();
    }
    Console.ReadLine();
  }
}
