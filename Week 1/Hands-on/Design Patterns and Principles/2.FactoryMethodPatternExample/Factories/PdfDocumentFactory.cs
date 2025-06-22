using FactoryMethodPatternExample.Interfaces;
using FactoryMethodPatternExample.Documents;

namespace FactoryMethodPatternExample.Factories
{
    public class PdfDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument() => new PdfDocument();
    }
}