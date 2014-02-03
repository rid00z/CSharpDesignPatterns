using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.TemplateMethod
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    class Products : DataAccessObject
    {
        public override void Select()
        {
            //Custom products select statement
        }

        public override void Process()
        {
            //Custom products process statement
        }
    }
}
