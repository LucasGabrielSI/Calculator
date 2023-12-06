namespace Calculator;

public class Calculator
{
  public static void Main(string[] args)
  {
    Menu();
  }

  static void Menu()
  {
		Console.Clear();
    
    Console.WriteLine("Digite o primeiro valor: ");
    double valor1 = float.Parse(Console.ReadLine()!);
    
    Console.WriteLine("Digite o segundo valor: ");
    double valor2 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("Digite a operacao que deseja realizar: ");
    Console.WriteLine("1 - Adicao");
    Console.WriteLine("2 - Subtracao");
    Console.WriteLine("3 - Multiplicacao");
    Console.WriteLine("4 - Divisao");
    short valorOperador = short.Parse(Console.ReadLine()!);

    switch(valorOperador)
    {
      case 1: Console.WriteLine($"total: {Sum(valor1, valor2)}"); break;
      case 2: Console.WriteLine($"total: {Subtraction(valor1, valor2)}"); break;
      case 3: Console.WriteLine($"total: {Multiplication(valor1, valor2)}"); break;
      case 4: Console.WriteLine($"total: {Division(valor1, valor2)}"); break;
      default: {
        Console.WriteLine("Operacao invalida, encerrando aplicacao...");
        Environment.Exit(0); 
        break;
      }
    }
  }

  static double Sum(double valor1, double valor2)
  {
    return valor1 + valor2;
  }

  static double Subtraction(double valor1, double valor2)
  {
    return valor1 - valor2;
  }

  static double Multiplication(double valor1, double valor2)
  {
    return valor1 * valor2;
  }

  static double Division(double valor1, double valor2)
  {
    return valor1 / valor2;
  }
}