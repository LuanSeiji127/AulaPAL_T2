int num, resto, cont = 0, qnt=0;

while (cont <= 15)
{

    Console.WriteLine("digite um número");
    num = int.Parse(Console.ReadLine());

    resto = cont % 2;

    if (resto == 0)
    {
        qnt++;
    }

    cont++;
}
Console.WriteLine("existem " + qnt + " pares");