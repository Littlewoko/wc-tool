if(args.Length == 0)
{
    Console.WriteLine("Welcome to this wc tool! Please provide arguments\n-c <file path>: prints the number of bytes in file");
    return;
}

try
{
    if (args[0].Equals("-c"))
    {
        var fileInfo = new FileInfo(args[1]);
        Console.WriteLine($"Bytes in file: {fileInfo.Length}");
    }
} catch(Exception ex)
{
    Console.WriteLine("Something went wrong");
}
