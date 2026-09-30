string nome, sexo;
int cont = 0;

while (cont <= 30)
{
    Console.WriteLine("Digite seu nome");
    nome = Console.ReadLine();

    Console.WriteLine("Digite seu sexo");
    sexo = Console.ReadLine();

    if ((sexo == "M") || (sexo == "m"))
    {
        Console.WriteLine("Funcionário: " +  nome + ". deve fazer o exame");
    }
    else
    {
        Console.WriteLine("Funcionário: " + nome + ". não precisa fazer o exame");
    }

    cont++;
}