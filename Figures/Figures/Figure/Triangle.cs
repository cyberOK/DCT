using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures.Figure
{
    class Triangle : AbstractFigure
    {
        public Triangle(Point startPosition, float size) : base(startPosition, size) { }

        public override void Draw(Graphics graphicsUnit)
        {
            Point[] cordinatesOfTops = GetCoordinatesOfTops();

            using (SolidBrush brushForFillFigure = new SolidBrush(Color.Green))
            {                
                graphicsUnit.FillPolygon(brushForFillFigure, cordinatesOfTops);
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

        private Point[] GetCoordinatesOfTops()
        {
            Point[] calculateTops = new Point[] { new Point(StartPosition.X, StartPosition.Y + 50),
                                                    new Point(StartPosition.X + 50, StartPosition.Y + 50),
                                                        new Point(StartPosition.X + 25, StartPosition.Y) };
            return calculateTops;
        }

        public override string ToString()
        {
            return "Triangle";
        }
    }
}
