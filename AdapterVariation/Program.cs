using System;

namespace AdapterVariation
{
    class Program
    {
        static void Main(string[] args)
        {
            IReport report = new WordReport();
            Console.WriteLine(report.Export());

            report = new ExcelReport();
            Console.WriteLine(report.Export());

            report = new Adapter( new ThirdPartPdfReport());
            Console.WriteLine(report.Export());

            Console.ReadKey();
        }
    }
}
