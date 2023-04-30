Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("==Múltiplos==");
Console.WriteLine("Digite um número...........:");
Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Black;
int numero = Convert.ToInt32(Console.ReadLine()!); Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Avaliar se é múltiplo de...:");
Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Black;
int numero2 = Convert.ToInt32(Console.ReadLine()!); Console.ResetColor();

if (numero % numero2 == 0)
{
    Console.WriteLine($"{numero} é múltiplo de {numero2}");
}
else
{
    Console.WriteLine($"{numero} não é  multiplo de {numero2}");
}