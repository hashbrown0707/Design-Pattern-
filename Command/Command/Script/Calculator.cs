using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Script
{
    /// <summary>
    /// Reciver
    /// </summary>
    class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Substract(int a, int b) => a - b;
        public int Multiplie(int a, int b) => a * b;
        public int Devide(int a, int b) => a / b;

    }
}
