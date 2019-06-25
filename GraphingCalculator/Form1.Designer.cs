namespace GraphingCalculator
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxFunctions = new System.Windows.Forms.CheckedListBox();
            this.pictureBoxCalculator = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalculator)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.functionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1564, 46);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveAsToolStripMenuItem1,
            this.saveAsToolStripMenuItem2,
            this.saveAsImageToolStripMenuItem,
            this.importToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.newToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.openToolStripMenuItem.Text = "New...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(266, 38);
            this.saveAsToolStripMenuItem.Text = "Open";
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(266, 38);
            this.saveAsToolStripMenuItem1.Text = "Save";
            // 
            // saveAsToolStripMenuItem2
            // 
            this.saveAsToolStripMenuItem2.Name = "saveAsToolStripMenuItem2";
            this.saveAsToolStripMenuItem2.Size = new System.Drawing.Size(266, 38);
            this.saveAsToolStripMenuItem2.Text = "Save as...";
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(266, 38);
            this.saveAsImageToolStripMenuItem.Text = "Save as image";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphFileToolStripMenuItem,
            this.pointSeriesToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(266, 38);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // graphFileToolStripMenuItem
            // 
            this.graphFileToolStripMenuItem.Name = "graphFileToolStripMenuItem";
            this.graphFileToolStripMenuItem.Size = new System.Drawing.Size(253, 38);
            this.graphFileToolStripMenuItem.Text = "Graph file...";
            // 
            // pointSeriesToolStripMenuItem
            // 
            this.pointSeriesToolStripMenuItem.Name = "pointSeriesToolStripMenuItem";
            this.pointSeriesToolStripMenuItem.Size = new System.Drawing.Size(253, 38);
            this.pointSeriesToolStripMenuItem.Text = "Point Series...";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(266, 38);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(266, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 36);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertFunctionToolStripMenuItem});
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(120, 36);
            this.functionToolStripMenuItem.Text = "Function";
            // 
            // insertFunctionToolStripMenuItem
            // 
            this.insertFunctionToolStripMenuItem.Name = "insertFunctionToolStripMenuItem";
            this.insertFunctionToolStripMenuItem.Size = new System.Drawing.Size(288, 38);
            this.insertFunctionToolStripMenuItem.Text = "Insert Function...";
            this.insertFunctionToolStripMenuItem.Click += new System.EventHandler(this.insertFunctionToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 46);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxFunctions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxCalculator);
            this.splitContainer1.Size = new System.Drawing.Size(1564, 931);
            this.splitContainer1.SplitterDistance = 520;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 10;
            // 
            // listBoxFunctions
            // 
            this.listBoxFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFunctions.FormattingEnabled = true;
            this.listBoxFunctions.Location = new System.Drawing.Point(0, 0);
            this.listBoxFunctions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxFunctions.Name = "listBoxFunctions";
            this.listBoxFunctions.Size = new System.Drawing.Size(510, 940);
            this.listBoxFunctions.TabIndex = 12;
            // 
            // pictureBoxCalculator
            // 
            this.pictureBoxCalculator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCalculator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCalculator.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCalculator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBoxCalculator.Name = "pictureBoxCalculator";
            this.pictureBoxCalculator.Size = new System.Drawing.Size(1036, 931);
            this.pictureBoxCalculator.TabIndex = 11;
            this.pictureBoxCalculator.TabStop = false;
            this.pictureBoxCalculator.SizeChanged += new System.EventHandler(this.pictureBoxCalculator_SizeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 977);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Graphing Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalculator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointSeriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox listBoxFunctions;
        private System.Windows.Forms.PictureBox pictureBoxCalculator;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertFunctionToolStripMenuItem;
    }
}

