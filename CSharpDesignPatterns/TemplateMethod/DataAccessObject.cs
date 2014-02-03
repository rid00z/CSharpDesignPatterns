using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.TemplateMethod
{
    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    abstract class DataAccessObject
    {
        protected string _connectionString;
        protected DataSet _dataSet;

        public virtual void Connect()
        {
            //connect to database
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            _connectionString = "";
        }

        // The 'Template Method'
        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}
