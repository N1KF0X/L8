using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8
{
    internal class LogDB: MyArray<string>
    {
        public LogDB(int lenght) : base(lenght) { }
    }

    internal class PassDB: MyArray<string>
    {
        public PassDB(int lenght) : base(lenght) { }
    }
}
