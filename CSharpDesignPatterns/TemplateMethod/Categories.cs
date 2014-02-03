using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.TemplateMethod
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    class Categories : DataAccessObject
    {
        public override void Select()
        {
            //Custom categories select statement
        }

        public override void Process()
        {
            //Custom categories process statement
        }
    }
}
