Console.WriteLine("********Exercício Tabuada**********");


Console.WriteLine("Entre com um npumero para tabuada");
int numInformado = int.Parse(Console.ReadLine());


for(int i = 0; i <= 10; i++)
{
    Console.WriteLine(numInformado + " x " + i + " = " + (i * numInformado));
}