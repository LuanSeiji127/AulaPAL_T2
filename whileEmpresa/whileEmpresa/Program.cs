string nome, sexo;
int cont = 0;

while(cont <= 15)
{
    Console.WriteLine("digite seu nome");
    nome = Console.ReadLine();

    Console.WriteLine("Digite seu Sexo");
    sexo = Console.ReadLine();

    if (sexo == "M")
    {
        Console.WriteLine("O " + nome +" Necessita o Exame");
    }
    else if (sexo == "F")
    {
        Console.WriteLine("A "+ nome +" Não necessita o exame");
    }
    else
    {
        Console.WriteLine("sexo digitado incorretamente");
    }
    cont++;
}