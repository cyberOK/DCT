namespace Figures
{
    partial class FiguresForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonForRectangle = new System.Windows.Forms.Button();
            this.buttonforCircle = new System.Windows.Forms.Button();
            this.buttonForTriangle = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.MainFiguresBox = new System.Windows.Forms.PictureBox();
            this.treeFigures = new System.Windows.Forms.TreeView();
            this.timerForRedrawForm = new System.Windows.Forms.Timer(this.components);
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.toolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainFiguresBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolPanel
            // 
            this.toolPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolPanel.Controls.Add(this.buttonSaveFile);
            this.toolPanel.Controls.Add(this.buttonOpenFile);
            this.toolPanel.Controls.Add(this.buttonStop);
            this.toolPanel.Controls.Add(this.buttonForRectangle);
            this.toolPanel.Controls.Add(this.buttonforCircle);
            this.toolPanel.Controls.Add(this.buttonForTriangle);
            this.toolPanel.Location = new System.Drawing.Point(126, -2);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(675, 50);
            this.toolPanel.TabIndex = 0;
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Location = new System.Drawing.Point(587, 14);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonForRectangle
            // 
            this.buttonForRectangle.Location = new System.Drawing.Point(432, 14);
            this.buttonForRectangle.Name = "buttonForRectangle";
            this.buttonForRectangle.Size = new System.Drawing.Size(75, 23);
            this.buttonForRectangle.TabIndex = 2;
            this.buttonForRectangle.Text = "Rectangle";
            this.buttonForRectangle.UseVisualStyleBackColor = true;
            this.buttonForRectangle.Click += new System.EventHandler(this.buttonForRectangle_Click);
            // 
            // buttonforCircle
            // 
            this.buttonforCircle.Location = new System.Drawing.Point(351, 14);
            this.buttonforCircle.Name = "buttonforCircle";
            this.buttonforCircle.Size = new System.Drawing.Size(75, 23);
            this.buttonforCircle.TabIndex = 1;
            this.buttonforCircle.Text = "Circle";
            this.buttonforCircle.UseVisualStyleBackColor = true;
            this.buttonforCircle.Click += new System.EventHandler(this.buttonforCircle_Click);
            // 
            // buttonForTriangle
            // 
            this.buttonForTriangle.Location = new System.Drawing.Point(270, 14);
            this.buttonForTriangle.Name = "buttonForTriangle";
            this.buttonForTriangle.Size = new System.Drawing.Size(75, 23);
            this.buttonForTriangle.TabIndex = 0;
            this.buttonForTriangle.Text = "Triangle";
            this.buttonForTriangle.UseVisualStyleBackColor = true;
            this.buttonForTriangle.Click += new System.EventHandler(this.buttonForTriangle_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(-1, -2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(130, 453);
            this.treeView1.TabIndex = 1;
            // 
            // MainFiguresBox
            // 
            this.MainFiguresBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFiguresBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainFiguresBox.Location = new System.Drawing.Point(129, 47);
            this.MainFiguresBox.Name = "MainFiguresBox";
            this.MainFiguresBox.Size = new System.Drawing.Size(672, 404);
            this.MainFiguresBox.TabIndex = 2;
            this.MainFiguresBox.TabStop = false;
            this.MainFiguresBox.Resize += new System.EventHandler(this.MainFiguresBox_Resize);
            // 
            // treeFigures
            // 
            this.treeFigures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeFigures.Location = new System.Drawing.Point(-1, 1);
            this.treeFigures.Name = "treeFigures";
            this.treeFigures.Size = new System.Drawing.Size(130, 450);
            this.treeFigures.TabIndex = 3;
            // 
            // timerForRedrawForm
            // 
            this.timerForRedrawForm.Enabled = true;
            this.timerForRedrawForm.Tick += new System.EventHandler(this.timerForRedrawForm_Tick);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(10, 14);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 4;
            this.buttonOpenFile.Text = "Open";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(92, 13);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveFile.TabIndex = 5;
            this.buttonSaveFile.Text = "Save";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            // 
            // FiguresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeFigures);
            this.Controls.Add(this.MainFiguresBox);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolPanel);
            this.Name = "FiguresForm";
            this.RightToLeftLayout = true;
            this.Text = "FiguresForm";
            this.toolPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainFiguresBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Button buttonForRectangle;
        private System.Windows.Forms.Button buttonforCircle;
        private System.Windows.Forms.Button buttonForTriangle;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox MainFiguresBox;
        private System.Windows.Forms.TreeView treeFigures;
        private System.Windows.Forms.Timer timerForRedrawForm;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonOpenFile;
    }
}