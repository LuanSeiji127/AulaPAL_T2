int qtd = 0,num, resto = 0;

for (int i = 1; i <= 300; i++)
{
    resto = i % 3;

    if ( resto == 0)
    {
        Console.WriteLine(i + " multiplo de 3 ");
        qtd++;
    }
}

Console.WriteLine("as quantidade de números são " + qtd);