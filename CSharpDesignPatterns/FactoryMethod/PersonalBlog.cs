using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.FactoryMethod
{
    class PersonalBlog : Blog
    {
        public override void CreatePages()
        {
            Pages.Add(new HomeBlogPage());
            Pages.Add(new MainBlogPage());
        }
    }
}
