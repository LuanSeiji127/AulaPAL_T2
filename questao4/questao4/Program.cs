string nome;
double notaA,notaB,media, cont = 0;

while (cont <= 5)
{
    Console.WriteLine("digite seu nome");
    nome = Console.ReadLine();
    Console.WriteLine("digite a nota A");
    notaA = double.Parse(Console.ReadLine());
    Console.WriteLine("digite a nota B");
    notaB = double.Parse(Console.ReadLine());

    media = (notaA + notaB) / 2;
    Console.WriteLine("sua média é de " + media);
    cont++;
}
