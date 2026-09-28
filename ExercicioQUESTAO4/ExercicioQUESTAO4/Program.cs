int num, soma= 0;

Console.WriteLine("digite um número");
num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    soma =soma + i;
}

Console.WriteLine("o resultado é: " + soma);