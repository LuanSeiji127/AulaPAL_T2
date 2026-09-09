int num;
double conta,cont = 10;

Console.WriteLine("Digite um número");
num = int.Parse(Console.ReadLine());

while (cont <= num)
{
    conta = cont/ 3;

    Console.WriteLine("resultado: " + cont + " / 3 = " + conta);
    cont++;
}
