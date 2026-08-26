int cont =  1, ano_nas, ano_atual, idade;

while (cont <= 5)
{
    Console.WriteLine("digite seu ano de nascimento ");
    ano_nas = int.Parse(Console.ReadLine());

    Console.WriteLine("digite o ano atual");
    ano_atual = int.Parse(Console.ReadLine());

    idade = ano_atual - ano_nas;

    Console.WriteLine("Sua idade é: " + idade);
    cont++;
}