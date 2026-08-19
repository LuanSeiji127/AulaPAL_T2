string sexo, nome;
int idade;
for (int i = 1; i <= 3;  i++)
{
Console.WriteLine("digite sua nome");
    nome = Console.ReadLine();

Console.WriteLine("digite seu idade");
    idade = int.Parse(Console.ReadLine());


Console.WriteLine("Qual seu sexo");
    sexo = Console.ReadLine();

    if ((sexo == "m") && (idade >= 21))
        {
        Console.WriteLine("você é do sexo masculino, tem mais de 21 anos " + nome);
    }
}