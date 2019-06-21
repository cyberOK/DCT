using System.Drawing;

namespace Figures.Figure
{
    public class Rectangle : AbstractFigure
    {
        public Rectangle(Point startPosition, float size) : base(startPosition, size)
        { }

        public override void Draw(Graphics graphicsUnit)
        {
            using (SolidBrush brushForFillFigure = new SolidBrush(Color.Red))
            {
                graphicsUnit.FillRectangle(brushForFillFigure, StartPosition.X, StartPosition.Y, this.SizeForFigure, this.SizeForFigure);
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
            return "Rectangle";
        }
    }
}
