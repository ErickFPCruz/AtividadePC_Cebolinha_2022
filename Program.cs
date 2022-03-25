Console.Clear();

string fraseDigitada, fraseDoCebolinha;

Console.Write("Digite qualquer coisa: ");
fraseDigitada = Console.ReadLine()!;

fraseDoCebolinha = fraseDigitada.Replace("r", "l").Replace("R", "L");
Console.WriteLine();

Console.WriteLine(fraseDoCebolinha);
Console.WriteLine();