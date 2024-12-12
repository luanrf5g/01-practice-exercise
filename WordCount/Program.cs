namespace WordCount;

class Program
{
  public static void Main()
  {
    Console.WriteLine("Insira qualquer palavra ou texto, e iremos contar quantos caracteres possui.");
    Console.Write("x. ");

    string text = Console.ReadLine() ?? "";

    string newText = text.Trim();

    Console.WriteLine("O texto que você digitou possui " + newText.Length + " caracteres, excluindo os espaços em branco");
  }
}