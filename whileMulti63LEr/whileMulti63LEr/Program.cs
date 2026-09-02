int cont = 0, num;
double multi;

while (cont <= 3)
{
    Console.WriteLine("Digite um número");
    num = int.Parse(Console.ReadLine());
    multi = num * 6;
    Console.WriteLine("O resultado é de " + multi);
    cont++;
}