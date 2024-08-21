using wc_tool;

if (args.Length == 0)
{
    Console.WriteLine("Welcome to this wc tool! Please provide arguments\n-c <file path>: prints the number of bytes in file");
    return;
}

try
{
    var argsParser = new ArgsParser();
    var parsedArgs = argsParser.ParseArgs(args);

    foreach(var arg in parsedArgs)
    {
        Console.WriteLine(arg.Run());
    }

} catch(Exception ex)
{
    Console.WriteLine("Something went wrong...");
    Console.WriteLine(ex.Message);
}
