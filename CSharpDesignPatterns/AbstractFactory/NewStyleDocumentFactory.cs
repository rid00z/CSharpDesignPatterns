using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.AbstractFactory
{
    class NewStyleDocumentFactory : IDocumentFactory
    {
        public Document CreateDocument()
        {
            //create new style document
            return new Document();
        }
    }
}
