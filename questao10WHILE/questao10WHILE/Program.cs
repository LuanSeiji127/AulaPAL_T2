int cont = 0, ponto=0;
string res1, res2, res3;

while (cont <= 30)
{
    Console.WriteLine("Digite sua resposta da questão 1");
    res1 = Console.ReadLine();

    Console.WriteLine("Digite sua resposta da questão 2");
    res2 = Console.ReadLine();

    Console.WriteLine("Digite sua resposta da questão 3");
    res3 = Console.ReadLine();

    if ((res1 == "A") || (res2 == "C") || (res3 =="D"))
    {
        ponto++;
    }
    else
    {
        Console.WriteLine("Resposta incorreta");
    }
    cont++;
}

Console.WriteLine("Pontuação Final: " + ponto);