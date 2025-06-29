using System;
using FactoryMethodPatternExample.Interfaces;

namespace FactoryMethodPatternExample.Documents
{
    public class ExcelDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening Excel document...");
    }
}