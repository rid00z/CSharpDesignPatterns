using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.Strategy
{
    public class WinServerAuthenticate : IAuthenticate
    {
        public bool Login(string user, string password)
        {
            //authenticate via win server
            return false;
        }
    }
}
