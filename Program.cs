using System;

class MainClass {
  public static void Main (string[] args) {
     
    Console.Write("Digite algo:\t");
    string texto = Console.ReadLine();
    Console.Write(texto.ToUpper());
  }
}