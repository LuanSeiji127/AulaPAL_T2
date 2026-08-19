int soma = 0, num;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("digite o número");
    num = int.Parse(Console.ReadLine());
    soma = num + soma;
    

}

Console.WriteLine("A soma de todos os números é: " + soma);