using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.Command
{
    class Client
    {
        void main()
        {
            var electricDuck = new ElectricDuck();

            var flyCommand = new FlyCommand(electricDuck);
            var runCommand = new RunCommand(electricDuck);

            var remote = new RemoteControl();
            remote.SetCommand(flyCommand);
            remote.ExecuteCommand();

            remote.SetCommand(runCommand);
            remote.ExecuteCommand();
        }
    }
}
