int cont = 0, num;
double conta;

Console.WriteLine("Digite um número");
num = int.Parse(Console.ReadLine());


while (cont <= num)
{
    conta = cont * 2;
    Console.WriteLine("Dobro do número digitado " + conta);
    cont++;
}