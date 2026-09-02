int cont = 1, qtd = 0, resto;

while (cont <= 750)
{
    resto = cont % 4;
    
    if (resto == 0)
    {
        Console.WriteLine(cont);
        qtd++;
    }
    cont++;
}

Console.WriteLine("A quantidade de multiplos de 4 são " + qtd);
