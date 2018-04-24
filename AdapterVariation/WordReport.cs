using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterVariation
{
    public class WordReport : IReport
    {
        public string Export()
        {
            return "Export Word Report";
        }
    }
}
