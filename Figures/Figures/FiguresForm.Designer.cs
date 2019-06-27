using System.Globalization;

namespace FiguresForm
{
    partial class MainFiguresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFiguresForm));
            this.toolPanel = new System.Windows.Forms.Panel();
            this.buttonSubstractCollisionEvent = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.buttonAddCollisionEvent = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonForRectangle = new System.Windows.Forms.Button();
            this.buttonforCircle = new System.Windows.Forms.Button();
            this.buttonForTriangle = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.MainFiguresBox = new System.Windows.Forms.PictureBox();
            this.treeFigures = new System.Windows.Forms.TreeView();
            this.timerForRedrawForm = new System.Windows.Forms.Timer(this.components);
            this.toolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainFiguresBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolPanel
            // 
            resources.ApplyResources(this.toolPanel, "toolPanel");
            this.toolPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolPanel.Controls.Add(this.buttonSubstractCollisionEvent);
            this.toolPanel.Controls.Add(this.languageComboBox);
            this.toolPanel.Controls.Add(this.buttonAddCollisionEvent);
            this.toolPanel.Controls.Add(this.buttonSaveFile);
            this.toolPanel.Controls.Add(this.buttonOpenFile);
            this.toolPanel.Controls.Add(this.buttonStop);
            this.toolPanel.Controls.Add(this.buttonForRectangle);
            this.toolPanel.Controls.Add(this.buttonforCircle);
            this.toolPanel.Controls.Add(this.buttonForTriangle);
            this.toolPanel.Name = "toolPanel";
            // 
            // buttonSubstractCollisionEvent
            // 
            resources.ApplyResources(this.buttonSubstractCollisionEvent, "buttonSubstractCollisionEvent");
            this.buttonSubstractCollisionEvent.Name = "buttonSubstractCollisionEvent";
            this.buttonSubstractCollisionEvent.UseVisualStyleBackColor = true;
            this.buttonSubstractCollisionEvent.Click += new System.EventHandler(this.buttonSubstractCollisionEvent_Click);
            // 
            // languageComboBox
            // 
            resources.ApplyResources(this.languageComboBox, "languageComboBox");            
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            ((object)(resources.GetObject("languageComboBox.Items"))),
            ((object)(resources.GetObject("languageComboBox.Items1")))});
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.DataSource = new System.Globalization.CultureInfo[] {
        new System.Globalization.CultureInfo("en"),
        new System.Globalization.CultureInfo("ru")};
            this.languageComboBox.DisplayMember = "NativeName";
            this.languageComboBox.ValueMember = "Name";
            this.languageComboBox.SelectedValueChanged += new System.EventHandler(this.languageComboBox_SelectedValueChanged);
            // 
            // buttonAddCollisionEvent
            // 
            resources.ApplyResources(this.buttonAddCollisionEvent, "buttonAddCollisionEvent");
            this.buttonAddCollisionEvent.Name = "buttonAddCollisionEvent";
            this.buttonAddCollisionEvent.UseVisualStyleBackColor = true;
            this.buttonAddCollisionEvent.Click += new System.EventHandler(this.buttonAddCollisionEvent_Click);
            // 
            // buttonSaveFile
            // 
            resources.ApplyResources(this.buttonSaveFile, "buttonSaveFile");
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonOpenFile
            // 
            resources.ApplyResources(this.buttonOpenFile, "buttonOpenFile");
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonStop
            // 
            resources.ApplyResources(this.buttonStop, "buttonStop");
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonForRectangle
            // 
            resources.ApplyResources(this.buttonForRectangle, "buttonForRectangle");
            this.buttonForRectangle.Name = "buttonForRectangle";
            this.buttonForRectangle.UseVisualStyleBackColor = true;
            this.buttonForRectangle.Click += new System.EventHandler(this.buttonForRectangle_Click);
            // 
            // buttonforCircle
            // 
            resources.ApplyResources(this.buttonforCircle, "buttonforCircle");
            this.buttonforCircle.Name = "buttonforCircle";
            this.buttonforCircle.UseVisualStyleBackColor = true;
            this.buttonforCircle.Click += new System.EventHandler(this.buttonforCircle_Click);
            // 
            // buttonForTriangle
            // 
            resources.ApplyResources(this.buttonForTriangle, "buttonForTriangle");
            this.buttonForTriangle.Name = "buttonForTriangle";
            this.buttonForTriangle.UseVisualStyleBackColor = true;
            this.buttonForTriangle.Click += new System.EventHandler(this.buttonForTriangle_Click);
            // 
            // treeView1
            // 
            resources.ApplyResources(this.treeView1, "treeView1");
            this.treeView1.Name = "treeView1";
            // 
            // MainFiguresBox
            // 
            resources.ApplyResources(this.MainFiguresBox, "MainFiguresBox");
            this.MainFiguresBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainFiguresBox.Name = "MainFiguresBox";
            this.MainFiguresBox.TabStop = false;
            this.MainFiguresBox.Resize += new System.EventHandler(this.MainFiguresBox_Resize);
            // 
            // treeFigures
            // 
            resources.ApplyResources(this.treeFigures, "treeFigures");
            this.treeFigures.Name = "treeFigures";
            // 
            // timerForRedrawForm
            // 
            this.timerForRedrawForm.Enabled = true;
            this.timerForRedrawForm.Tick += new System.EventHandler(this.timerForRedrawForm_Tick);
            // 
            // MainFiguresForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeFigures);
            this.Controls.Add(this.MainFiguresBox);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolPanel);
            this.Name = "MainFiguresForm";
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
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Button buttonSubstractCollisionEvent;
        private System.Windows.Forms.Button buttonAddCollisionEvent;
    }
}