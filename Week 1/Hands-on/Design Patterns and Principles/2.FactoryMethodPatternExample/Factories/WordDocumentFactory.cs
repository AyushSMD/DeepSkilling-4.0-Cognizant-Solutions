using FactoryMethodPatternExample.Interfaces;
using FactoryMethodPatternExample.Documents;

namespace FactoryMethodPatternExample.Factories
{
    public class WordDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument() => new WordDocument();
    }
}