using FileCount;



FileInformation objecte = new FileInformation();

string path = @"D:\C#";

List<FileInformation> listExtensions = new List<FileInformation>();

objecte.GetDirectory(path);

objecte.GetExtensions(listExtensions);

objecte.OrderByDescending(listExtensions);


foreach (var extension in listExtensions)
{
    Console.WriteLine(extension.GetListExtensions());
}

Console.ReadLine();

