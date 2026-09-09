int num, cont = 0, conta;

Console.WriteLine("digite sua tabuada");
num = int.Parse(Console.ReadLine());

while (cont <= 30)
{
    conta = cont * num;
    Console.WriteLine(num + " x " + cont + " = " + conta);
    cont++;
}
