using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FiguresBase.Figures;
using FiguresBase;

namespace FiguresForm
{
    public interface IFiguresForm
    {
        string FilePath { get; }
        IEnumerable<AbstractFigure> FiguresOnDesk { get; set; }
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
    }

    public partial class MainFiguresForm : Form,IFiguresForm
    {
        #region Variables

        private Graphics graphicsUnit;
        private List<AbstractFigure> figuresOnDesk;
        private Random randomForPosition;
        private Point startPosition;
        private float sizeForFigures = 50;
        private Size sizeOfMainFiguresBox;
        private string filePath;

        #endregion

        #region Properties

        public string FilePath
        {
            get => this.filePath;
        }

        public IEnumerable<AbstractFigure> FiguresOnDesk
        {
            get => figuresOnDesk;
            set => figuresOnDesk = (List<AbstractFigure>)value; 
        }

        #endregion

        #region Cunstructor of Form

        public MainFiguresForm()
        {
            this.InitializeComponent();
            this.figuresOnDesk = new List<AbstractFigure>();
            this.timerForRedrawForm.Enabled = true;
            this.sizeOfMainFiguresBox = this.MainFiguresBox.Size;          
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
            AbstractFigure rectangle = new FiguresBase.Figures.Rectangle(startPosition, sizeForFigures);
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

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();

            oFD.Filter = "Binnary files (.dat)|*.dat|" + "XML files (.xml)|*.xml|" + "Json Files (.json)|*.json";
            
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                this.filePath = oFD.FileName;

                FileOpenClick?.Invoke(this, EventArgs.Empty);
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sFD = new SaveFileDialog();
            sFD.DefaultExt = ".dat";

            sFD.Filter = "Binnary files (.dat)|*.dat|" + "XML files (.xml)|*.xml|" + "Json Files (.json)|*.json";

            if(sFD.ShowDialog() == DialogResult.OK)
            {
                this.filePath = sFD.FileName;

                FileSaveClick?.Invoke(this, EventArgs.Empty);
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

        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
    }
}
