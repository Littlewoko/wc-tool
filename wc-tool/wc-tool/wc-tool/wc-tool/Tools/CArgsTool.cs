using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wc_tool;

public class CArgsTool : IArgsTool
{
    string _filePath;
    public CArgsTool(string filePath)
    {
        _filePath = filePath;
    }

    public string Run()
    {
        var fileInfo = new FileInfo(_filePath);
        return $"Bytes in {_filePath}: {fileInfo.Length}";
    }
}
