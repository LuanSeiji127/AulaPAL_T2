int qtd = 0, num, resto;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("digite o número");
    num = int.Parse(Console.ReadLine());

    resto = num % 4;
    if (resto == 0)
    {
        qtd++;
    }
}

Console.WriteLine("A quantidade de número com multíplo de 4 é : " + qtd);

