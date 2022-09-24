// See https://aka.ms/new-console-template for more information
using Парсер;
while (true)
{ 
    Console.WriteLine("Введите имя файла в формате FileName.format");
    string File = Console.ReadLine();


    FileParser.GetParser(File);
    
    
}