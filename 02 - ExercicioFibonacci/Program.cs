Console.WriteLine("*********Sequencia de Fibonacci*********");


Console.WriteLine("Entre até o número final que será exibida a sequencia de Fibonacci: ");
int numInformado = int.Parse(Console.ReadLine());

int anterior = 0;
int atual = 1;

Console.WriteLine(anterior);
Console.WriteLine(atual);

for  (int i = 0; atual <= numInformado; i++)
{
    int proximo = anterior + atual;

    if( proximo > numInformado)
    {
        break;
    }

    Console.WriteLine(proximo);

    anterior = atual;
    atual = proximo;
}