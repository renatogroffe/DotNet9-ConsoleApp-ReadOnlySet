using System.Collections.ObjectModel;
using System.Text.Json;

var campeoesMundiais = new HashSet<string>()
{
    "...",
    "Brasil",
    "Italia",
    "Alemanha",
    "Argentina",
    "Uruguai",
    "Franca",
    "Inglaterra",
    "Espanha",
    "????"
};
var campeoesMundiaisReadOnly = new ReadOnlySet<string>(campeoesMundiais);

var serializerOptions = new JsonSerializerOptions() { WriteIndented = true };

Console.WriteLine();
Console.WriteLine("JSON com os dados iniciais - HashSet<string>: ");
Console.WriteLine(JsonSerializer.Serialize(campeoesMundiais));

Console.WriteLine();
Console.WriteLine("ReadOnlySet<string> com valores iniciais: ");
Console.WriteLine(JsonSerializer.Serialize(campeoesMundiaisReadOnly));

campeoesMundiais.Remove("...");
campeoesMundiais.Remove("????");

Console.WriteLine();
Console.WriteLine("HashSet<string> apos modificacoes: ");
Console.WriteLine(JsonSerializer.Serialize(campeoesMundiais));

Console.WriteLine();
Console.WriteLine("ReadOnlySet<string> apos modificacoes em HashSet<string>: ");
Console.WriteLine(JsonSerializer.Serialize(campeoesMundiaisReadOnly));

Console.WriteLine();
Console.WriteLine($"Numero de paises que ja venceram Copas - usando ReadOnlySet<string>: " +
    campeoesMundiaisReadOnly.Count);