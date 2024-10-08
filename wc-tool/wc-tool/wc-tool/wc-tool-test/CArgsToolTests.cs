﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wc_tool;

namespace wc_tool_test;

public class CArgsToolTests
{
    [Theory]
    [InlineData("test.txt", 11)]
    [InlineData("test2.txt", 36)]
    public void RunShouldReturnBytesInFile(string path, int bytes)
    {
        var cArgsTool = new CArgsTool(path);

        var result = cArgsTool.Run();

        Assert.Equal($"Bytes in {path}: {bytes}", result);
    }

    [Fact]
    public void RunShouldThrowIfFileDoesNotExist()
    {
        var testFile = "test";
        var cArgsTool = new CArgsTool(testFile);

        Assert.Throws<FileNotFoundException>(() => cArgsTool.Run());
    }
}
