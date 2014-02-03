using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.FactoryMethod
{
    abstract class Blog
    {
        private List<IBlogPage> _pages = new List<IBlogPage>();
 
        // Constructor calls abstract Factory method
        public Blog()
        {
          this.CreatePages();
        }
 
        public List<IBlogPage> Pages
        {
          get { return _pages; }
        }
 
        // Factory Method
        public abstract void CreatePages();
    }
}
