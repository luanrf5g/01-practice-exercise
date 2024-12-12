namespace Calc;

public class OperacoesMatematicas
{
  public static void Somar(double valor1, double valor2)
  {
    double resultado = valor1 + valor2;

    Console.WriteLine("A Soma é: " + resultado.ToString("F"));
  }

  public static void Subtrair(double valor1, double valor2)
  {
    double resultado = valor1 - valor2;

    Console.WriteLine("A Subtração é: " + resultado.ToString("F"));
  }

  public static void Multiplicar(double valor1, double valor2)
  {
    double resultado = valor1 * valor2;

    Console.WriteLine("A multiplicação é: " + resultado.ToString("F"));
  }

  public static void Divisao(double valor1, double valor2)
  {
    if (valor2 <= 0)
    {
      Console.WriteLine("O segundo valor não pode ser atribuído como 0 para a divisão");
      return;
    }

    double resultado = valor1 / valor2;

    Console.WriteLine("A divisão é: " + resultado.ToString("F"));
  }

  public static void Media(double valor1, double valor2)
  {
    double resultado = (valor1 + valor2) / 2;

    Console.WriteLine("A média é: " + resultado.ToString("F"));
  }
}
