Console.WriteLine("******Exercício Par e impar na crescente e decrescente******");


Console.WriteLine("Digite um número para exibir os pares e ímpares: ");
int numInformado = int.Parse(Console.ReadLine());

for (int i = numInformado; i != 0; i--)
{

    if (i % 2 == 0)
    {
        Console.WriteLine("números pares: " + i);
    }

}

for (int a = 0; numInformado >= a; a++)
{

    if (!(a % 2 == 0))
    {
        Console.WriteLine("números ímpares: " + a);
    }

}