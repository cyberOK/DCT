using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures.Figure
{
    class Circle : AbstractFigure
    {
        public Circle(Point startPosition, float size) : base(startPosition, size) { }

        public override void Draw(Graphics graphicsUnit)
        {
            using (SolidBrush brushForFillFigure = new SolidBrush(Color.Blue))
            {
                graphicsUnit.FillEllipse(brushForFillFigure, StartPosition.X, StartPosition.Y, SizeForFigure, SizeForFigure);
            }
        }

        public override void Move(Point sizeOfMainPictureBox)
        {
            if (!IsStoped)
            {
                if (StartPosition.X <= 0 || StartPosition.X >= (sizeOfMainPictureBox.X - SizeForFigure))
                    dx = -dx;
                if (StartPosition.Y <= 0 || StartPosition.Y >= (sizeOfMainPictureBox.Y - SizeForFigure))
                    dy = -dy;

                StartPosition = new Point { X = dx, Y = dy };
                IntersectZone = new System.Drawing.Rectangle { X = dx, Y = dy, Height = (int)SizeForFigure, Width = (int)SizeForFigure };
            }
        }

        public override string ToString()
        {
            return "Circle";
        }

        
    }
}
