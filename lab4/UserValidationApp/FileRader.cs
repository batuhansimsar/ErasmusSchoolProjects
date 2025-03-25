using System;
using System.IO;

public class FileReader
{
    public void ReadFile(string filename)
    {
        string content = File.ReadAllText(filename);
        Console.WriteLine(content);
    }
}