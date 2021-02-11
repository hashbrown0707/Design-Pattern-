using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Script
{
    class HorizontalMovement : IStrategy
    {
        private string input;

        public void Move()
        {
            input = Console.ReadLine();

            if (input == "a")
                Console.WriteLine("Move left");
            else if (input == "d")
                Console.WriteLine("Move right");

            input = null;
        }
    }
}
