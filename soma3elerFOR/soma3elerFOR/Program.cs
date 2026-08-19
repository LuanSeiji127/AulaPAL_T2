int num = 0, qnt = 1, resto, soma;

for (int i = 1; i <= 50; i++)
{
    resto = i % 3;

    if (resto == 0 )
    {
        num = num + i;    
    }
}

Console.WriteLine("A soma é: " + num);
