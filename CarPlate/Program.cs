namespace CarPlate;

class Program
{
  public static void Main()
  {
    string carLicensePlate;

    Console.Write("Insira a placa do carro conforme o padrão brasileiro ( sem caractere especial ): ");
    carLicensePlate = Console.ReadLine() ?? "";

    for (int i = 0; i < 3; i++)
    {
      bool result = Char.IsLetter(carLicensePlate[i]);

      if (!result)
      {
        Console.WriteLine("Esta placa não é válida, pois não segue o padrão brasileiro.");
        return;
      }
    }

    for (int i = 3; i < 7; i++)
    {
      bool result = Char.IsNumber(carLicensePlate[i]);

      if (!result)
      {
        Console.WriteLine("Está placa não é válida, pois não segue o padrão brasileiro.");

        return;
      }
    }

    Console.WriteLine("Placa confirmada, esta placa segue o padrão brasileiro");
  }
}