using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Script
{
    class Program
    {
        static void Main(string[] args)
        {
            IStrategy horizontalStrategy = new HorizontalMovement();
            IStrategy verticalStrategy = new VerticalMovement();

            Cube cube = new Cube(horizontalStrategy);
            cube.StartMove(3);     //還能走3步

            cube = new Cube(verticalStrategy);
            cube.StartMove(5);       //還能走5步

            Console.Read();
        }
    }
}
