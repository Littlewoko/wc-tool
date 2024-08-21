using wc_tool;

namespace wc_tool_test;

public class ArgsParserTests
{
    ArgsParser argsParser;

    public ArgsParserTests()
    {
        argsParser = new ArgsParser();
    }

    [Fact]
    public void ParseArgsShouldMapCFunctionToArgsTool()
    {
        string[] args = { "-c", "test.txt" };

        var parsedArgs = argsParser.ParseArgs(args);

        for (int i = 0; i < args.Length; i++) 
        {
            Assert.IsAssignableFrom<IArgsTool>(parsedArgs[0]);
        }
    }

    [Fact]
    public void ParseArgsShouldThrowIfArgumentHasNoFunction()
    {
        string[] args = { "test.text" };

        Assert.Throws<ArgumentException>(() => argsParser.ParseArgs(args));
    }

    [Fact]
    public void ParseArgsShouldThrowIfArgumentIsFunction()
    {
        string[] args = { "-c", "-c" };

        Assert.Throws<ArgumentException>(() => argsParser.ParseArgs(args));
    }

    [Fact]
    public void ParseArgsShouldThrowIfNotEnoughArgs()
    {
        string[] args = { "-c" };

        Assert.Throws<ArgumentException>(() => argsParser.ParseArgs(args));
    }
}