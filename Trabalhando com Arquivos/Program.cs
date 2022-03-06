using System;
using static System.Console;

// Criar Menu


static void InsertText(string path)
{
    var update_file = File.CreateText(path);
    WriteLine("Digite o que deve ser gravada separado por espaco:");
    string[] inserts = ReadLine().Split(" ");

    foreach (string insert in inserts)
    {
        update_file.WriteLine(insert);
    }

    update_file.Flush();
}


static void CreateFile(string name)
{
    try
    {
        var path = Path.Combine(Environment.CurrentDirectory, $"{name}.txt");
        File.Create(path);
    }
    catch
    {
        foreach (var invalid_char in Path.GetInvalidFileNameChars())
        {
            name.Replace(invalid_char, '-');
        }

        var path = Path.Combine(Environment.CurrentDirectory, $"{name}.txt");
        File.Create(path);
    }
}