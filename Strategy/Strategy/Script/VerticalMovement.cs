using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Script
{
    class VerticalMovement : IStrategy
    {
        private string input;

        public void Move()
        {
            input = Console.ReadLine();

            if (input == "w")
                Console.WriteLine("Move up");
            else if (input == "s")
                Console.WriteLine("Move down");

            input = null;
        }
    }
}
