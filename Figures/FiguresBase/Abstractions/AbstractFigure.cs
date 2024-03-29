﻿using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Threading;
using FiguresBase.EventArguments;
using FiguresBase.Figures;

namespace FiguresBase
{
    [KnownType(typeof(Circle))]
    [KnownType(typeof(Figures.Rectangle))]
    [KnownType(typeof(Triangle))]
    [DataContract]
    [Serializable]
    public abstract class AbstractFigure
    {
        #region Fields

        [DataMember]
        public int dx = 20, dy = 5;

        private Point startPosition;
        private float sizeForFigures;
        private Point speed;
        private System.Drawing.Rectangle intersectZone;

        #endregion

        #region Constructors

        public AbstractFigure() { }

        public AbstractFigure(Point startPosition, float size)
        {
            this.IsStoped = false;
            this.startPosition = startPosition;
            this.sizeForFigures = size;
            this.speed = startPosition;
            this.intersectZone = new System.Drawing.Rectangle { X = startPosition.X, Y = startPosition.Y, Width = (int)size, Height = (int)size };
        }

        #endregion

        #region Properties

        [DataMember]
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

        [DataMember]
        public Point StartPosition
        {
            get => this.startPosition;
            set
            {
                this.startPosition.X += value.X;
                this.startPosition.Y += value.Y;
            }
        }

        [DataMember]
        public float SizeForFigure
        {
            get => this.sizeForFigures;
            private set => this.sizeForFigures = value;
        }

        [DataMember]
        public Point Speed
        {
            get => this.speed;
            private set => this.speed = value;
        }

        public bool IsStoped { get; set; }

        #endregion

        #region Abstract methods Move,Draw

        public abstract void Move(Point p);

        public abstract void Draw(Graphics g);

        #endregion

        #region Events and Invocations

        public void CollisionOccur(System.Drawing.Rectangle collisionCoordinate)
        {
            CollisionEventArgs e = new CollisionEventArgs(collisionCoordinate);

            OnCollision(e);
        }

        public virtual void OnCollision(CollisionEventArgs e)
        {
            EventHandler<CollisionEventArgs> temp = Volatile.Read(ref Collision);

            if(temp != null)
            {
                temp(this, e);
            }
        }

        public event EventHandler<CollisionEventArgs> Collision;

        #endregion
    }
}
