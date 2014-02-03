using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.Singleton
{
    class CarSingleton
    {
        static readonly object _padlock = new object();
        static CarSingleton _instance;

        public CarSingleton Instance
        {
            get
            {
                lock(_padlock)
                {
                    if (_instance == null)
                        _instance = new CarSingleton();
                    return _instance;
                }
            }
        }
    }
}
