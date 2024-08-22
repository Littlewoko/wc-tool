using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wc_tool;

namespace wc_tool_test;

public class WArgsToolTests
{
    [Theory]
    [InlineData("test.txt", 2)]
    [InlineData("test2.txt", 8)]
    [InlineData("test3.txt", 10)]
    public void RunShouldReturnWordsInFile(string path, int words)
    {
        var wArgsTool = new WArgsTool(path);

        var result = wArgsTool.Run();

        Assert.Equal($"Words in {path}: {words}", result);
    }

    [Fact]
    public void RunShouldThrowIfFileDoesNotExist()
    {
        var testFile = "test";
        var wArgsTool = new WArgsTool(testFile);

        Assert.Throws<FileNotFoundException>(() => wArgsTool.Run());
    }
}
