int num, cont = 1, soma;

Console.WriteLine("digite o número");
num = int.Parse(Console.ReadLine());

while (cont <= num)
{
    soma = cont + num;
    Console.WriteLine("resultado: " + cont + " + " + num + " = " + soma);
    cont++;
}