double num, met;

for (int i = 1; i < 10; i++)
{
    Console.WriteLine("Digite o numero");
    num = double.Parse(Console.ReadLine());

    met = num / 2;
    Console.WriteLine("a metade do numero é: " + met);
}