namespace DashaScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.niApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lSavingPath = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.gbSavingPath = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lHotKey = new System.Windows.Forms.Label();
            this.tbChar = new System.Windows.Forms.TextBox();
            this.rbCtrl = new System.Windows.Forms.RadioButton();
            this.rbAlt = new System.Windows.Forms.RadioButton();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.cmsTray.SuspendLayout();
            this.gbSavingPath.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // niApp
            // 
            this.niApp.ContextMenuStrip = this.cmsTray;
            this.niApp.Icon = ((System.Drawing.Icon)(resources.GetObject("niApp.Icon")));
            this.niApp.Text = "DashaScreen";
            this.niApp.Visible = true;
            this.niApp.DoubleClick += new System.EventHandler(this.niApp_DoubleClick);
            // 
            // cmsTray
            // 
            this.cmsTray.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cmsTray.Name = "cmsTray";
            this.cmsTray.Size = new System.Drawing.Size(173, 64);
            this.cmsTray.Text = "test text";
            // 
            // showHideToolStripMenuItem
            // 
            this.showHideToolStripMenuItem.Name = "showHideToolStripMenuItem";
            this.showHideToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.showHideToolStripMenuItem.Text = "Show/Hide";
            this.showHideToolStripMenuItem.Click += new System.EventHandler(this.showHideToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 286);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lSavingPath
            // 
            this.lSavingPath.AutoSize = true;
            this.lSavingPath.Location = new System.Drawing.Point(15, 32);
            this.lSavingPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSavingPath.Name = "lSavingPath";
            this.lSavingPath.Size = new System.Drawing.Size(93, 20);
            this.lSavingPath.TabIndex = 3;
            this.lSavingPath.Text = "lSavingPath";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(236, 117);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 68);
            this.button3.TabIndex = 4;
            this.button3.Text = "Change Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gbSavingPath
            // 
            this.gbSavingPath.Controls.Add(this.lSavingPath);
            this.gbSavingPath.Location = new System.Drawing.Point(18, 18);
            this.gbSavingPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSavingPath.Name = "gbSavingPath";
            this.gbSavingPath.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSavingPath.Size = new System.Drawing.Size(554, 75);
            this.gbSavingPath.TabIndex = 5;
            this.gbSavingPath.TabStop = false;
            this.gbSavingPath.Text = "Saving path";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lHotKey);
            this.groupBox1.Controls.Add(this.tbChar);
            this.groupBox1.Location = new System.Drawing.Point(18, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(208, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set buttons";
            // 
            // lHotKey
            // 
            this.lHotKey.AutoSize = true;
            this.lHotKey.Location = new System.Drawing.Point(9, 32);
            this.lHotKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHotKey.Name = "lHotKey";
            this.lHotKey.Size = new System.Drawing.Size(46, 20);
            this.lHotKey.TabIndex = 3;
            this.lHotKey.Text = "Ctrl +";
            // 
            // tbChar
            // 
            this.tbChar.Location = new System.Drawing.Point(66, 28);
            this.tbChar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbChar.Name = "tbChar";
            this.tbChar.ReadOnly = true;
            this.tbChar.Size = new System.Drawing.Size(120, 26);
            this.tbChar.TabIndex = 2;
            this.tbChar.Text = "T";
            this.tbChar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbChar_KeyDown);
            // 
            // rbCtrl
            // 
            this.rbCtrl.AutoSize = true;
            this.rbCtrl.Location = new System.Drawing.Point(40, 251);
            this.rbCtrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbCtrl.Name = "rbCtrl";
            this.rbCtrl.Size = new System.Drawing.Size(58, 24);
            this.rbCtrl.TabIndex = 3;
            this.rbCtrl.TabStop = true;
            this.rbCtrl.Text = "Ctrl";
            this.rbCtrl.UseVisualStyleBackColor = true;
            // 
            // rbAlt
            // 
            this.rbAlt.AutoSize = true;
            this.rbAlt.Location = new System.Drawing.Point(110, 251);
            this.rbAlt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAlt.Name = "rbAlt";
            this.rbAlt.Size = new System.Drawing.Size(53, 24);
            this.rbAlt.TabIndex = 4;
            this.rbAlt.TabStop = true;
            this.rbAlt.Text = "Alt";
            this.rbAlt.UseVisualStyleBackColor = true;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(408, 117);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(164, 68);
            this.btnOpenFolder.TabIndex = 5;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 200);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.rbCtrl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rbAlt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSavingPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashaScreen";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.cmsTray.ResumeLayout(false);
            this.gbSavingPath.ResumeLayout(false);
            this.gbSavingPath.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon niApp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip cmsTray;
        private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lSavingPath;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gbSavingPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAlt;
        private System.Windows.Forms.RadioButton rbCtrl;
        private System.Windows.Forms.TextBox tbChar;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label lHotKey;
    }
}

