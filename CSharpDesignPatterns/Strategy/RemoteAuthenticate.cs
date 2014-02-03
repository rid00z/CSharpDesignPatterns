using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.Strategy
{
    public class RemoteAuthenticate : IAuthenticate
    {
        public bool Login(string user, string password)
        {
            //authenticate remotely
            return false;
        }
    }
}
