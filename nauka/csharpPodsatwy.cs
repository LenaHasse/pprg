int wiek=67;

if (wiek < 13)
{
    Console.WriteLine("dziecko");
}
else if (wiek >= 13 && wiek <= 17)
{
    Console.WriteLine("nastolatek");
}
else if (wiek >= 18 && wiek <= 64)
{
    Console.WriteLine("dorosły");
}
else
{
    Console.WriteLine("senior");
}