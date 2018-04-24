using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterVariation
{
    class Adapter : IReport
    {
        private ThirdPartPdfReport _thirdPartPdfReport;
        public Adapter(ThirdPartPdfReport thirdPartPdfReport)
        {
            _thirdPartPdfReport = thirdPartPdfReport;
        }
        public string Export()
        {
            return _thirdPartPdfReport.Save();
        }
    }
}
