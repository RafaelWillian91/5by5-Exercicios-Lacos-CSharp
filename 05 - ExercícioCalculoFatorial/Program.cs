
Console.WriteLine("******** Calculo Fatorial **********");


Console.WriteLine("Digite um número para exibir o seu fatorial: ");
int numInformado = int.Parse(Console.ReadLine());
int fatorial = 1;


if (numInformado < 0)
{
    Console.WriteLine("Não existe fatorial de número negativo");
}
else
{
    for (int i = 2; i <= numInformado; i++)
    {

        fatorial *= i;
    }
    Console.WriteLine("Fatorial de " + numInformado + " = " + fatorial);
}

