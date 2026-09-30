
int cont = 0, qnt = 0, resto;

while (cont <= 900)
{
    resto = cont % 2;

    if (resto != 0)
    {
        Console.WriteLine(cont);
        qnt++;
    }
    cont++;
}

Console.WriteLine("Quantidade de multiplos de 3 " + qnt);