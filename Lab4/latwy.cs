//zad1
Console.WriteLine("while: ");
int liczba=1;
while (liczba < 11)
{
    Console.WriteLine(liczba);
    liczba++;
}

liczba = 1;
Console.WriteLine("\ndo-while: ");
do
{
    Console.WriteLine(liczba);
    liczba++;
} 
while (liczba < 11);

Console.WriteLine("\nfor: ");
for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i);
}
Console.Write("Malejąco: ");
//zad1 czesc 2
for (int i=10; i>0; i--)
{
    Console.Write(i+" ");
}
Console.Write("\nParzyste: ");
for (int i = 0; i < 21; i += 2)
{
    Console.Write(i+" ");
}
Console.WriteLine("\nStart!");