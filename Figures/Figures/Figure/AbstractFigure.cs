using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

namespace Figures.Figure
{
    public abstract class AbstractFigure
    {
        private Point startPosition;
        private float sizeForFigures;
        private Point speed;
        protected System.Drawing.Rectangle intersectZone;

        public int dx = 20, dy = 5;

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

        abstract public void Move(Point p);
        abstract public void Draw(Graphics g);
    }
}
