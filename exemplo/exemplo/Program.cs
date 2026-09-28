string sexo;
int idade, cont = 1 ;

while (cont <= 3)
{
    Console.WriteLine("Digite sua idade");
    idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite sexo M ou F");
    sexo = Console.ReadLine();

    if ((sexo == "F") || (sexo == "f"))
    {
        Console.WriteLine("O sexo é feminino e sua idade " + idade);
    }
}