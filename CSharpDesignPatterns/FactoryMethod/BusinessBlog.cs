using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.FactoryMethod
{
    class BusinessBlog : Blog
    {
        public override void CreatePages()
        {
            Pages.Add(new HomeBlogPage());
            Pages.Add(new MainBlogPage());
            Pages.Add(new AboutUsBlogPage());
        }
    }
}
