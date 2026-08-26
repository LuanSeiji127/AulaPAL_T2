
double quadrado, num, cont = 1;

Console.WriteLine("Digite seu número:  ");
num = int.Parse(Console.ReadLine());


while (cont <= num)
{
    quadrado = Math.Pow(cont, 2);
    Console.WriteLine(cont + "² =" + quadrado);
    cont++;
}