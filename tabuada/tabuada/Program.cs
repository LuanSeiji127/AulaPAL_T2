int tabuada;
double conta;
Console.WriteLine("digite a tabuada");
tabuada = int.Parse(Console.ReadLine());

for (int i = 1;  i <= 10; i++)
{
    conta = tabuada * i;

    Console.WriteLine(tabuada + " x " + i + " = " + conta);
}