using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.AbstractFactory
{
    class OldStyleDocumentFactory : IDocumentFactory
    {
        public Document CreateDocument()
        {
            //create old style document
            return new Document();
        }
    }
}
