Console.WriteLine("**********  Repeticoes  ***********");

int contador = 10;

while (contador > 0)
{
    Console.WriteLine(contador);
    contador--;
    Thread.Sleep(100);
}
Console.WriteLine("Happy new year!!!");


do
{
    contador++;
    Console.WriteLine(contador);
    Thread.Sleep(100);
} while (contador < 10);
Console.WriteLine("Happy new year!!!");

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
    Thread.Sleep(100);
}
Console.WriteLine("Happy new year com for!!!");