using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wc_tool;

namespace wc_tool_test;

public class LArgsToolTests
{
    [Theory]
    [InlineData("test.txt", 1)]
    [InlineData("test2.txt", 7)]
    public void RunShouldReturnLinesInFile(string path, int lines)
    {
        var lArgsTool = new LArgsTool(path); 
        var res = lArgsTool.Run();

        Assert.Equal($"Lines in {path}: {lines}", res);
    }

    [Fact]
    public void RunShouldThrowIfFileDoesNotExist()
    {
        var testFile = "test";
        var cArgsTool = new LArgsTool(testFile);

        Assert.Throws<FileNotFoundException>(() => cArgsTool.Run());
    }
}
