int cont = 1, num, conta = 0;

while (cont <= 5)
{
    Console.WriteLine("digite um número");
    num = int.Parse(Console.ReadLine());
    conta = conta + num;
    cont++;
}
    Console.WriteLine("o resultado é " + conta);