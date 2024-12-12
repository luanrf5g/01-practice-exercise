namespace ConcatName;

class Program
{
  public static void Main()
  {
    string firstName = "";
    string secondName = "";

    Console.Write("Digite o seu primeiro nome: ");
    firstName = Console.ReadLine() ?? "";

    Console.Write("Digite o seu sobrenome: ");
    secondName = Console.ReadLine() ?? "";

    string name = firstName + " " + secondName;

    Console.WriteLine(name);
  }
}