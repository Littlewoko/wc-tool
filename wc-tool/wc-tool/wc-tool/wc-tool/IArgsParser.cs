using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wc_tool;

interface IArgsParser
{
    IList<IArgsTool> ParseArgs(string[] args);
}
