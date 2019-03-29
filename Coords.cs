using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    public struct Coords
    {
        double x;
        double y;

        public Coords(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Coords(Random random)
        {
            this.x = random.NextDouble();
            this.y = random.NextDouble();
        }

        public double Hypo()
        {
             return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
        }
    }
}
