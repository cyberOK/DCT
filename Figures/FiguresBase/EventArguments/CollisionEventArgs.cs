using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresBase.EventArguments
{
    public class CollisionEventArgs:EventArgs
    {
        private readonly Rectangle collisionCoordinate;

        public CollisionEventArgs(Rectangle collisionCoordinate)
        {
            this.collisionCoordinate = collisionCoordinate;    
        }

        public Rectangle CollisionCordinate
        {
            get
            {
                return this.collisionCoordinate;
            }
        }
    }
}
