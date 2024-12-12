using System.Formats.Tar;
using System.Globalization;

namespace DateInfo;

class Program
{
  public static void Main()
  {
    string option;
    DateTime hoje = DateTime.Now;
    DateTime completo = new(hoje.Year, hoje.Month, hoje.Day, hoje.Hour, hoje.Minute, hoje.Second);

    Console.WriteLine("Selecione como você deseja que a data atual seja informada:");
    Console.WriteLine("1. Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
    Console.WriteLine("2. Apenas a data no formato '01/03/2024'");
    Console.WriteLine("3. Apenas a hora no formato de 24 horas");
    Console.WriteLine("4. A data com o mês por extenso");
    Console.Write("Opção: ");
    option = Console.ReadLine() ?? "2";

    switch (option)
    {
      case "1":
        Console.WriteLine("Data Atual: " + hoje);
        break;
      case "2":
        Console.WriteLine("Fomato dd/mm/yyyy: " + completo.ToString("d", new CultureInfo("pt-BR")));
        break;
      case "3":
        Console.WriteLine("Apenas a hora: " + completo.ToString("HH", new CultureInfo("pt-BR")));
        break;
      case "4":
        Console.WriteLine("A data com o mês por extenso: " + completo.ToString(@"d \de MMMM \de yyyy"));
        break;
      default:
        break;
    }
  }
}