string ReadCommand()
{
    while (true)
    {
        Console.WriteLine("1. Opcja pierwsza\n2.Opcja druga\n3.Opcja trzecia");
        Console.Write("Wybór: ");
        string? command = Console.ReadLine();
        if (command is "1" or "2" or "3")
        {
            return command;
        }
        else
        {
            Console.WriteLine("Podałeś złą liczbę");
            continue;
        }
    }
}
ReadCommand();