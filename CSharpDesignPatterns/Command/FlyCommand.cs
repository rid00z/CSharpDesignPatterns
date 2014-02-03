using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.Command
{
    class FlyCommand : ICommand
    {
        ElectricDuck _duck;
        public FlyCommand(ElectricDuck duck)
        {
            _duck = duck;
        }

        public void ExecuteCommand()
        {
            _duck.Fly();
        }
    }
}
