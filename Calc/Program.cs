namespace Calc;

class Program
{
  public static void Main()
  {
    double valor1, valor2;

    Console.Write("Digite dois valores do tipo double, separados pelo ponto e vírgula: ");
    string digitado = Console.ReadLine() ?? "";

    if (digitado == "")
    {
      Console.WriteLine("Valores digitados incorretamente");
      return;
    }

    string[] trim = digitado.Split(";");
    if (trim.Length < 2)
    {
      Console.WriteLine("Os valores digitados não são válidos");
      return;
    }

    valor1 = Convert.ToDouble(trim[0]);
    valor2 = Convert.ToDouble(trim[1]);

    OperacoesMatematicas.Somar(valor1, valor2);
    OperacoesMatematicas.Subtrair(valor1, valor2);
    OperacoesMatematicas.Multiplicar(valor1, valor2);
    OperacoesMatematicas.Divisao(valor1, valor2);
    OperacoesMatematicas.Media(valor1, valor2);
  }
}