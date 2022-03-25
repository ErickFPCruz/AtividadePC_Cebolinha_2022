Console.Clear();

string fraseDigitada, fraseDoCebolinha;

Console.Write($"Digite qualquer coisa: {Console.ReadLine()}");

fraseDigitada = Console.ReadLine();

fraseDoCebolinha = fraseDigitada.Replace("r", "l").Replace("R", "L");

Console.WriteLine(fraseDoCebolinha);