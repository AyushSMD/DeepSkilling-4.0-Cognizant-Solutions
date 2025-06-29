using System;
using FactoryMethodPatternExample.Interfaces;

namespace FactoryMethodPatternExample.Documents
{
    public class PdfDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening PDF document...");
    }
}