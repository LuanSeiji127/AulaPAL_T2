int num, qnt = 1, resto;

for  (int i = 1; i <= 15; i++)
{
    Console.WriteLine("digite o número");
    num = int.Parse(Console.ReadLine());

    resto = num % 2;

    if (resto == 0)
    {
        qnt++;
    }
}

Console.WriteLine("a quantidade de número par são " + qnt);