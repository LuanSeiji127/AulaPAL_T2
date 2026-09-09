int  num;

Console.WriteLine("digite o numero");
num = int.Parse(Console.ReadLine());

int cont = num;

while (cont >= 0)
{
    Console.WriteLine(cont);
    cont--;
}