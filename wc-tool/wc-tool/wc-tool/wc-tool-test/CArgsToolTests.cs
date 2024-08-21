using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wc_tool;

namespace wc_tool_test;

public class CArgsToolTests
{
    [Fact]
    public void RunShouldReturnBytesInFile()
    {
        var testFile = "test.txt";

        var cArgsTool = new CArgsTool(testFile);

        var result = cArgsTool.Run();

        Assert.Equal($"Bytes in {testFile}: 11", result);
    }

    [Fact]
    public void RunShouldThrowIfFileDoesNotExist()
    {
        var testFile = "test";
        var cArgsTool = new CArgsTool(testFile);

        Assert.Throws<FileNotFoundException>(() => cArgsTool.Run());
    }
}
