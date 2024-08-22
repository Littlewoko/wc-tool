using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wc_tool;

public class LArgsTool : IArgsTool
{
    string _filePath;
    public LArgsTool(string filePath) { _filePath = filePath; }

    public string Run()
    {
        var fileLines = File.ReadAllLines(_filePath);
        return $"Lines in {_filePath}: {fileLines.Length}";
    }
}
