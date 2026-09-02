int cont = 0, resto,num, qtd=0;

while (cont <= 20)
{
    Console.WriteLine("Digite um número");
    num = int.Parse(Console.ReadLine());
    resto = num % 3;

    if(resto == 0)
    {

        qtd++;
    }
    cont++;
}

Console.WriteLine("a quantidade de multiplos de 3 é: " + qtd);