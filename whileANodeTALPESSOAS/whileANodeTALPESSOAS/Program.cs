int cont = 0, ano_atual, ano_nas, conta;

Console.WriteLine("Digite o ano Atual");
ano_atual = int.Parse(Console.ReadLine());

while (cont <= 4)
{
    Console.WriteLine("Digite o ano de nascimento");
    ano_nas = int.Parse(Console.ReadLine());
    conta = ano_atual - ano_nas;
    Console.WriteLine("sua idade é de " +  conta);
    cont++;
}
