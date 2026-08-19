double num = 0;
int qtdpos = 0, qtneg = 0;

for (int i = 1; i <= 10; i = i + 1)
{
    Console.WriteLine("digite o numero");
    num = double.Parse(Console.ReadLine());
    if (num > 0)
    {
       qtdpos = qtdpos+1;
    }
    else if (num < 0)
    {
        qtneg = qtneg+1;
    }

}

        Console.WriteLine("quantidade de numeros positivos: " + qtdpos);

        Console.WriteLine("quantidade de numeros negativos " + qtneg);
