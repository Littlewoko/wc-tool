using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace wc_tool;

public class WArgsTool : IArgsTool
{
    private readonly string _filePath;
    public WArgsTool(string filePath) 
    {
        _filePath = filePath;
    }

    public string Run()
    {
        var fileLines = File.ReadAllLines(_filePath);

        var numberOfWords = 0;
        foreach (var line in fileLines) 
        {
            if (String.IsNullOrEmpty(line)) continue;

            var pattern = @"[\s,.]+"; ;
            var seperatedWords = Regex.Replace(line, pattern, " ");

            var trimmed = seperatedWords.Trim();

            string[] words = trimmed.Split(" ");
            numberOfWords += words.Length;
        }

        return $"Words in {_filePath}: {numberOfWords}";
    }
}
