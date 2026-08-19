int qnt = 0, idade;

Console.WriteLine("qual idade?");
idade = int.Parse(Console.ReadLine());

for(int i= 1; i <= 5; i++)
{
    qnt = qnt + 1;

    if(idade >= 18 )
    {
        qnt++;
        Console.WriteLine("as idades são: " + qnt);
    }
}