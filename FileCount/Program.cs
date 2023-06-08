static void FileExtensionCount(string path)
{
    List<string> fileList = new List<string>();
    foreach (string file in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
    {
        fileList.Add(Path.GetExtension(file));
    }

    for (int i = 0; i < fileList.Count; i++)
    {
        int count = 1;
        for (int j = 1 + i; j < fileList.Count; j++)
        {
            if (fileList[i] == fileList[j])
            {
                fileList.RemoveAt(j);
                count++;
            }
        }
        Console.WriteLine("There are {0} files with extension {1}", count, fileList[i]);
    }
}
