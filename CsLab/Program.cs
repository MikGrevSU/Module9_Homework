using System;
using FileSystem;
using HomeTheater;

class Program
{
    static void Main()
    {
        Console.WriteLine("1 - Фасад (Мультимедийный центр)");
        Console.WriteLine("2 - Компоновщик (Файловая система)");
        var key = Console.ReadLine();

        if (key == "1") HomeTheaterProgram.Run();
        else if (key == "2") FileSystemProgram.Run();
    }
}

