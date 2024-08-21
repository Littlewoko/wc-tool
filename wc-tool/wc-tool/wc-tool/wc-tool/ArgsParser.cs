using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wc_tool;

public class ArgsParser : IArgsParser
{
    public IList<IArgsTool> ParseArgs(string[] args)
    {
        var res = new List<IArgsTool>();

        for (int i = 0; i < args.Length; i++)
        {
            string function = args[i];

            if (!function.StartsWith("-")) throw new ArgumentException("Failed to parse args. Argument had no matching function.");

            if (i + 1 >= args.Length) throw new ArgumentException("Failed to parse args. No parameter provided for function");
            
            string argument = args[++i];
            
            if (argument.StartsWith("-")) throw new ArgumentException("Failed to parse args. A function specifier cannot be used as an argument");
            
            if(function.ToLower().Equals("-c"))
            {
                res.Add(new CArgsTool(argument));
            }
        }

        return res;
    }
}
