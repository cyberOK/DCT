using System.Drawing;

namespace Figures.Figure
{
    public abstract class AbstractFigure
    {       
        public int dx = 20, dy = 5;

        private Point startPosition;
        private float sizeForFigures;
        private Point speed;
        private System.Drawing.Rectangle intersectZone;

        public AbstractFigure(Point startPosition, float size)
        {
            this.IsStoped = false;
            this.startPosition = startPosition;
            this.sizeForFigures = size;
            this.speed = startPosition;
            this.intersectZone = new System.Drawing.Rectangle { X = startPosition.X, Y = startPosition.Y, Width = (int)size, Height = (int)size };
        }

        #region Properties

        public virtual System.Drawing.Rectangle IntersectZone
        {
            get => this.intersectZone;
            set
            {
                this.intersectZone.X += value.X;
                this.intersectZone.Y += value.Y;
                this.intersectZone.Height = value.Height;
                this.intersectZone.Width = value.Width;
            }
        }

        public Point StartPosition
        {
            get => this.startPosition;
            set
            {
                this.startPosition.X += value.X;
                this.startPosition.Y += value.Y;
            }
        }

        public float SizeForFigure
        {
            get => this.sizeForFigures;
            private set => this.sizeForFigures = value;
        }

        public Point Speed
        {
            get => this.speed;
            private set => this.speed = value;
        }

        public bool IsStoped { get; set; }

        #endregion

        public abstract void Move(Point p);

        public abstract void Draw(Graphics g);
    }
}
