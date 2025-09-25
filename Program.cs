string frase, fraseCebolinha;

Console.Write("Escleva uma flase: ");

frase = Console.ReadLine()!;

fraseCebolinha = frase.Replace("r", "l").Replace("R", "L")!;

Console.WriteLine(fraseCebolinha);




