int cont = 1, num;
double conta;

while (cont <= 3)
{
    Console.WriteLine("Digite o valor");
    num = int.Parse(Console.ReadLine());
    conta = num * 7;
    Console.WriteLine("o resultado é: " +  conta);
    cont++;    

}