Console.WriteLine("***********Exercício números primos***********");


Console.WriteLine("Digite um número para exibir os seus primos: ");
int numInformado = int.Parse(Console.ReadLine());

//precisamos de dois for:
//O primeiro percorre os números de 2 até numInformado.
//O segundo verifica se cada número é primo, procurando divisores.
for (int i = 2; i <= numInformado; i++)
{

    bool ehPrimo = true;
    
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            ehPrimo = false;
            break;
        }

    }
    //Exemplo de saida: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37
    if (ehPrimo)
    {
        Console.WriteLine("primos :" + i);
    }
}