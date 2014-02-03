using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.Strategy
{
    interface IAuthenticate
    {
        bool Login(string user, string password);
    }
}
