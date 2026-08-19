int qnt = 1, qnt2 = 1;
string sexo;
double altura;

for (int i = 1; i <= 4; i++)
{
    Console.WriteLine("digite o sexo da pessoa");
    sexo = Console.ReadLine();

    Console.WriteLine("digite a altura da pessoa");
    altura = double.Parse(Console.ReadLine());

    if (sexo == "M")
    {
        qnt++;
    }

    if (sexo == "F")
    {
        Console.WriteLine(" você é do sexo feminino " + altura);
    }
}

Console.WriteLine("a quantidade de homems é: " + qnt);