double cont = 0, num, resto,conta;

while(cont <= 7)
{
    Console.WriteLine("digite um número: ");
    num = int.Parse(Console.ReadLine());

    resto = cont % 2;

    if (resto == 0)
    {
        conta = Math.Pow(num,2);
        Console.WriteLine("resultado: " + conta);
    }
    else
    {
        conta = Math.Pow(num,3);
        Console.WriteLine("resultado: " + conta);
    }
}