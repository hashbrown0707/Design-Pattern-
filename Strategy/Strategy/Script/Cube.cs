using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Script
{
    class Cube
    {
        private IStrategy movementStrategy;

        public Cube(IStrategy movementStrategy)
        {
            this.movementStrategy = movementStrategy;
        }

        public void StartMove(int remainingStep)
        {
            for (int i = 0; i < remainingStep; i++)
            {
                movementStrategy.Move();
            }
        }
    }
}
