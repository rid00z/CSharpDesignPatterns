using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.Command
{
    public class RunCommand : ICommand
    {
        ElectricDuck _duck;
        public RunCommand(ElectricDuck duck)
        {
            _duck = duck;
        }

        public void ExecuteCommand()
        {
            _duck.Run();
        }
    }
}
