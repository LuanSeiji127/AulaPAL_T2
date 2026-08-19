
double numero, conta;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("digite um número");
    numero = int.Parse(Console.ReadLine());
    conta = Math.Pow(numero,2);

    Console.WriteLine("resultado do número elevado é: " + conta);
}