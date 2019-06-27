using System;
using System.Drawing;

namespace FiguresBase.Figures
{
    [Serializable]
    public class Triangle : AbstractFigure
    {
        public Triangle() { }

        public Triangle(Point startPosition, float size) : base(startPosition, size)
        { }

        public override void Draw(Graphics graphicsUnit)
        {
            Point[] cordinatesOfTops = this.GetCoordinatesOfTops();

            using (SolidBrush brushForFillFigure = new SolidBrush(Color.Green))
            {                
                graphicsUnit.FillPolygon(brushForFillFigure, cordinatesOfTops);
            }
        }

        public override void Move(Point sizeOfMainPictureBox)
        {
            if (!this.IsStoped)
            {
                if (StartPosition.X <= 0 || StartPosition.X >= (sizeOfMainPictureBox.X - this.SizeForFigure))
                {
                    this.dx = -this.dx;
                }

                if (StartPosition.Y <= 0 || StartPosition.Y >= (sizeOfMainPictureBox.Y - this.SizeForFigure))
                {
                    this.dy = -this.dy;
                }

                this.StartPosition = new Point { X = dx, Y = dy };
                this.IntersectZone = new System.Drawing.Rectangle { X = dx, Y = dy, Height = (int)SizeForFigure, Width = (int)SizeForFigure };
            }          
        }

        public override string ToString()
        {
            return "Triangle";
        }

        private Point[] GetCoordinatesOfTops()
        {
            Point[] calculateTops = new Point[] 
            {
                new Point(StartPosition.X, StartPosition.Y + 50),
                new Point(StartPosition.X + 50, StartPosition.Y + 50),
                new Point(StartPosition.X + 25, StartPosition.Y)
            };

            return calculateTops;
        }
    }
}
