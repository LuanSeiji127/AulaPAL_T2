double resto;
int cont= 1, num;

Console.WriteLine("digite o número: ");
num = int.Parse(Console.ReadLine());

while (cont <= num)
{
    resto = cont % 2;

    if (resto == 0)
    {
        Console.WriteLine(cont);
    }
        cont++;
}