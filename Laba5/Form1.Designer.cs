namespace Laba5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashDotDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Coordinate = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPenSolid = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPenDot = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPenDashDotDot = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPenColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.openToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.penToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // penToolStripMenuItem
            // 
            this.penToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.penToolStripMenuItem.Name = "penToolStripMenuItem";
            this.penToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.penToolStripMenuItem.Text = "Pen";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.dotToolStripMenuItem,
            this.dashDotDotToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Checked = true;
            this.solidToolStripMenuItem.CheckOnClick = true;
            this.solidToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // dotToolStripMenuItem
            // 
            this.dotToolStripMenuItem.CheckOnClick = true;
            this.dotToolStripMenuItem.Name = "dotToolStripMenuItem";
            this.dotToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.dotToolStripMenuItem.Text = "Dot";
            this.dotToolStripMenuItem.Click += new System.EventHandler(this.dotToolStripMenuItem_Click);
            // 
            // dashDotDotToolStripMenuItem
            // 
            this.dashDotDotToolStripMenuItem.CheckOnClick = true;
            this.dashDotDotToolStripMenuItem.Name = "dashDotDotToolStripMenuItem";
            this.dashDotDotToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.dashDotDotToolStripMenuItem.Text = "DashDotDot";
            this.dashDotDotToolStripMenuItem.Click += new System.EventHandler(this.dashDotDotToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "F1";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Coordinate);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Location = new System.Drawing.Point(69, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 56);
            this.panel1.TabIndex = 1;
            // 
            // Coordinate
            // 
            this.Coordinate.AutoSize = true;
            this.Coordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Coordinate.Location = new System.Drawing.Point(27, 20);
            this.Coordinate.Name = "Coordinate";
            this.Coordinate.Size = new System.Drawing.Size(73, 16);
            this.Coordinate.TabIndex = 4;
            this.Coordinate.Text = "Coordinate";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(451, 8);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(265, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripButtonUndo,
            this.toolStripButtonRedo,
            this.toolStripButtonPenSolid,
            this.toolStripButtonPenDot,
            this.toolStripButtonPenDashDotDot,
            this.toolStripButtonPenColor,
            this.toolStripButtonExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(53, 426);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.AutoSize = false;
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(51, 31);
            this.toolStripButtonNew.Text = "New";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.AutoSize = false;
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(51, 31);
            this.toolStripButtonOpen.Text = "Open";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.AutoSize = false;
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(51, 31);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.AutoSize = false;
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(51, 31);
            this.toolStripButtonUndo.Text = "toolStripButtonUndo";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.AutoSize = false;
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedo.Image")));
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(51, 31);
            this.toolStripButtonRedo.Text = "toolStripButtonRedo";
            this.toolStripButtonRedo.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripButtonPenSolid
            // 
            this.toolStripButtonPenSolid.AutoSize = false;
            this.toolStripButtonPenSolid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPenSolid.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPenSolid.Image")));
            this.toolStripButtonPenSolid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPenSolid.Name = "toolStripButtonPenSolid";
            this.toolStripButtonPenSolid.Size = new System.Drawing.Size(51, 31);
            this.toolStripButtonPenSolid.Text = "toolStripButtonSolidPen";
            this.toolStripButtonPenSolid.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // toolStripButtonPenDot
            // 
            this.toolStripButtonPenDot.AutoSize = false;
            this.toolStripButtonPenDot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPenDot.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPenDot.Image")));
            this.toolStripButtonPenDot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPenDot.Name = "toolStripButtonPenDot";
            this.toolStripButtonPenDot.Size = new System.Drawing.Size(51, 31);
            this.toolStripButtonPenDot.Text = "toolStripButtonDotPen";
            this.toolStripButtonPenDot.Click += new System.EventHandler(this.dotToolStripMenuItem_Click);
            // 
            // toolStripButtonPenDashDotDot
            // 
            this.toolStripButtonPenDashDotDot.AutoSize = false;
            this.toolStripButtonPenDashDotDot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPenDashDotDot.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPenDashDotDot.Image")));
            this.toolStripButtonPenDashDotDot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPenDashDotDot.Name = "toolStripButtonPenDashDotDot";
            this.toolStripButtonPenDashDotDot.Size = new System.Drawing.Size(51, 31);
            this.toolStripButtonPenDashDotDot.Text = "toolStripButtonDashDotDotPen";
            this.toolStripButtonPenDashDotDot.Click += new System.EventHandler(this.dashDotDotToolStripMenuItem_Click);
            // 
            // toolStripButtonPenColor
            // 
            this.toolStripButtonPenColor.AutoSize = false;
            this.toolStripButtonPenColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPenColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPenColor.Image")));
            this.toolStripButtonPenColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPenColor.Name = "toolStripButtonPenColor";
            this.toolStripButtonPenColor.Size = new System.Drawing.Size(51, 31);
            this.toolStripButtonPenColor.Text = "toolStripButtonColor";
            this.toolStripButtonPenColor.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.AutoSize = false;
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(51, 31);
            this.toolStripButtonExit.Text = "toolStripButtonExit";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(69, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 338);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(694, 332);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashDotDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripButton toolStripButtonRedo;
        private System.Windows.Forms.ToolStripButton toolStripButtonPenSolid;
        private System.Windows.Forms.ToolStripButton toolStripButtonPenDot;
        private System.Windows.Forms.Label Coordinate;
        private System.Windows.Forms.ToolStripButton toolStripButtonPenDashDotDot;
        private System.Windows.Forms.ToolStripButton toolStripButtonPenColor;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

