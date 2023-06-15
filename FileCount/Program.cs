

using System.Linq;

DirectoryFilesExtensionCount(@"D:\C#");

static void DirectoryFilesExtensionCount(string directory)
{
    var filesCount = new DirectoryInfo(directory);

    var result = filesCount.EnumerateFiles("*", SearchOption.AllDirectories)
                           .GroupBy(file => file.Extension)
                           .Select(file => new { Extension = file.Key, Count = file.Count() })
                           .OrderByDescending(file => file.Count)
                           .ToList();

    result.ForEach(Console.WriteLine);
}
