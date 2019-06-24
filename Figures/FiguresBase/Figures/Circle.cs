using System;
using System.Drawing;

namespace FiguresBase.Figures
{
    [Serializable]
    public class Circle : AbstractFigure
    {
        public Circle() { }

        public Circle(Point startPosition, float size) : base(startPosition, size)
        { }
        
        public override void Draw(Graphics graphicsUnit)
        {
            using (SolidBrush brushForFillFigure = new SolidBrush(Color.Blue))
            {
                graphicsUnit.FillEllipse(brushForFillFigure, StartPosition.X, StartPosition.Y, this.SizeForFigure, this.SizeForFigure);
            }
        }

        public override void Move(Point sizeOfMainPictureBox)
        {
            if (!this.IsStoped)
            {
                if (this.StartPosition.X <= 0 || this.StartPosition.X >= (sizeOfMainPictureBox.X - this.SizeForFigure))
                {
                    this.dx = -this.dx;
                }

                if (this.StartPosition.Y <= 0 || this.StartPosition.Y >= (sizeOfMainPictureBox.Y - this.SizeForFigure))
                {
                    this.dy = -this.dy;
                }

                this.StartPosition = new Point { X = dx, Y = dy };
                this.IntersectZone = new System.Drawing.Rectangle { X = dx, Y = dy, Height = (int)SizeForFigure, Width = (int)SizeForFigure };
            }
        }

        public override string ToString()
        {
            return "Circle";
        }       
    }
}
