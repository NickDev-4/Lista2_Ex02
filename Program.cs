Console.Clear();

string Frase1, Flase2;
Console.Write("Digite uma Frase: ");

Frase1 = Console.ReadLine();

Flase2 = Frase1

.Replace("r", "l")
.Replace("R", "L");

Console.WriteLine();
Console.WriteLine("Frase do Cebolinha: {0}", Flase2);