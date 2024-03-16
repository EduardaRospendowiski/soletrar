String palavra;
Console.WriteLine("--- Soletrar ---");
Console.Write("digite um texto para se soletrado: ");

palavra = Console.ReadLine ()!;
Console.WriteLine(string.Join("-",palavra.ToCharArray()));