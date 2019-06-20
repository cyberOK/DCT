﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures.Figure;

namespace Figures
{
    public partial class FiguresForm : Form
    {
        #region Variables

        Graphics graphicsUnit;
        List<AbstractFigure> figuresOnDesk;
        Random randomForPosition;
        Point startPosition;
        float sizeForFigures = 50;
        Size sizeOfMainFiguresBox;

        #endregion

        #region Cunstructor of Form

        public FiguresForm()
        {
            InitializeComponent();
            figuresOnDesk = new List<AbstractFigure>();
            timerForRedrawForm.Enabled = true;
            sizeOfMainFiguresBox = MainFiguresBox.Size;           
        }

        #endregion

        #region Events of form

        private void timerForRedrawForm_Tick(object sender, EventArgs e)
        {
            using (graphicsUnit = MainFiguresBox.CreateGraphics())
            {
                MainFiguresBox.Refresh();
                
                foreach (AbstractFigure firstFigure in figuresOnDesk)
                {
                    if (figuresOnDesk.Count > 1)
                    {
                        CollisionCheck(firstFigure, figuresOnDesk);                       
                    }

                    firstFigure.Draw(graphicsUnit);
                    firstFigure.Move((Point)sizeOfMainFiguresBox);
                }                
            }
        }

        private void MainFiguresBox_Resize(object sender, EventArgs e)
        {
            sizeOfMainFiguresBox = MainFiguresBox.Size;
        }

        private void buttonForTriangle_Click(object sender, EventArgs e)
        {
            startPosition = GetStartPositionCoordinates();
            AbstractFigure triangle = new Triangle(startPosition, sizeForFigures);
            figuresOnDesk.Add(triangle);
            CreateNewTreeNode(triangle);

            using (graphicsUnit = MainFiguresBox.CreateGraphics())
            {
                triangle.Draw(graphicsUnit);
            }
        }

        private void buttonforCircle_Click(object sender, EventArgs e)
        {
            startPosition = GetStartPositionCoordinates();
            AbstractFigure circle = new Circle(startPosition, sizeForFigures);
            figuresOnDesk.Add(circle);
            CreateNewTreeNode(circle);

            using (graphicsUnit = MainFiguresBox.CreateGraphics())
            {
                circle.Draw(graphicsUnit);
            }
        }

        private void buttonForRectangle_Click(object sender, EventArgs e)
        {
            startPosition = GetStartPositionCoordinates();
            AbstractFigure rectangle = new Figure.Rectangle(startPosition, sizeForFigures);
            figuresOnDesk.Add(rectangle);
            CreateNewTreeNode(rectangle);

            using (graphicsUnit = MainFiguresBox.CreateGraphics())
            {
                rectangle.Draw(graphicsUnit);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeFigures.SelectedNode;
            
            if (selectedNode != null)
            {
                var figure = (AbstractFigure)selectedNode.Tag;
                if (figure.IsStoped)
                    figure.IsStoped = false;
                else figure.IsStoped = true;
            }            
        }

        #endregion

        #region Helpful methods

        private void CreateNewTreeNode(AbstractFigure figureForNode)
        {
            TreeNode newNode = new TreeNode();
            newNode.Text = figureForNode.ToString();
            newNode.Tag = figureForNode;
            treeFigures.Nodes.Add(newNode);
        }

        private Point GetStartPositionCoordinates()
        {
            randomForPosition = new Random();
            Point startCoordinates = new Point
            {
                X = randomForPosition.Next((int)sizeForFigures, sizeOfMainFiguresBox.Width - (int)sizeForFigures),
                Y = randomForPosition.Next((int)sizeForFigures, sizeOfMainFiguresBox.Height - (int)sizeForFigures)
            };
            return startCoordinates;
        }

        private void CollisionCheck(AbstractFigure figureToCheck, IEnumerable<AbstractFigure> figureCollection)
        {
            foreach (AbstractFigure secondFigure in figuresOnDesk)
            {               
                if (figureToCheck.Equals(secondFigure))
                    continue;
                else if (figureToCheck.IntersectZone.IntersectsWith(secondFigure.IntersectZone))
                {
                    figureToCheck.dx = -figureToCheck.dx;
                    figureToCheck.dy = -figureToCheck.dy;
                    figureToCheck.StartPosition = new Point { X = figureToCheck.dx, Y = figureToCheck.dy };

                    secondFigure.dx = -figureToCheck.dx;
                    secondFigure.dy = -figureToCheck.dy;
                    secondFigure.StartPosition = new Point { X = secondFigure.dx, Y = secondFigure.dy };
                }
            }
        }

        #endregion
    }
}
