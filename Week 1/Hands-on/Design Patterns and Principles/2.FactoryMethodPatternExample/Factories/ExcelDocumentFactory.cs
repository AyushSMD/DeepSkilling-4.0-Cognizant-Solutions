using FactoryMethodPatternExample.Interfaces;
using FactoryMethodPatternExample.Documents;

namespace FactoryMethodPatternExample.Factories
{
    public class ExcelDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument() => new ExcelDocument();
    }
}