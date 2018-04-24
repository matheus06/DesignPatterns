using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterVariation
{
    public class ExcelReport : IReport
    {
        public string Export()
        {
            return "Export Excel Report";
        }
    }
}
