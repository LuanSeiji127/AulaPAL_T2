double cont = 0, multi, num;

while(cont <= 3)
{
    Console.WriteLine("digite um numero");
    num = double.Parse(Console.ReadLine());
    multi = num * 9;

    Console.WriteLine("resultado: " + multi);
    cont++;
}