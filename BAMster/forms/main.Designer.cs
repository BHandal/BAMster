namespace BAMster
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.browseBtn = new System.Windows.Forms.Button();
            this.sampleListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msgLabel = new System.Windows.Forms.Label();
            this.executeBtn = new System.Windows.Forms.Button();
            this.utilityBtn = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.analysisTab = new System.Windows.Forms.TabPage();
            this.featureBox = new System.Windows.Forms.TextBox();
            this.sampleList = new System.Windows.Forms.ListBox();
            this.consoleTab = new System.Windows.Forms.TabPage();
            this.terminal = new ConsoleControl.ConsoleControl();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.bamStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.sampleListMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.analysisTab.SuspendLayout();
            this.consoleTab.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseBtn
            // 
            this.browseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.browseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseBtn.Location = new System.Drawing.Point(489, 218);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 25);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "BROWSE";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // sampleListMenu
            // 
            this.sampleListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.sampleListMenu.Name = "sampleListMenu";
            this.sampleListMenu.Size = new System.Drawing.Size(158, 70);
            // 
            // viewInToolStripMenuItem
            // 
            this.viewInToolStripMenuItem.Image = global::BAMster.Properties.Resources.glyphicons_389_new_window_alt;
            this.viewInToolStripMenuItem.Name = "viewInToolStripMenuItem";
            this.viewInToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewInToolStripMenuItem.Text = "View in explorer";
            this.viewInToolStripMenuItem.Click += new System.EventHandler(this.viewInToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::BAMster.Properties.Resources.glyphicons_016_bin;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // msgLabel
            // 
            this.msgLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msgLabel.AutoSize = true;
            this.msgLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.msgLabel.Location = new System.Drawing.Point(132, 96);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(297, 30);
            this.msgLabel.TabIndex = 58;
            this.msgLabel.Text = "Drag and Drop BAM/SAM files";
            // 
            // executeBtn
            // 
            this.executeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.executeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.executeBtn.Enabled = false;
            this.executeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeBtn.Location = new System.Drawing.Point(9, 308);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(564, 32);
            this.executeBtn.TabIndex = 59;
            this.executeBtn.Text = "ANALYZE";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // utilityBtn
            // 
            this.utilityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.utilityBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.utilityBtn.Enabled = false;
            this.utilityBtn.Location = new System.Drawing.Point(495, 0);
            this.utilityBtn.Name = "utilityBtn";
            this.utilityBtn.Size = new System.Drawing.Size(75, 24);
            this.utilityBtn.TabIndex = 60;
            this.utilityBtn.Text = "CLEAR";
            this.utilityBtn.UseVisualStyleBackColor = true;
            this.utilityBtn.Click += new System.EventHandler(this.utilityBtn_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(580, 24);
            this.menuStrip.TabIndex = 61;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewerToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "FILE";
            // 
            // viewerToolStripMenuItem
            // 
            this.viewerToolStripMenuItem.Image = global::BAMster.Properties.Resources.glyphicons_027_search;
            this.viewerToolStripMenuItem.Name = "viewerToolStripMenuItem";
            this.viewerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewerToolStripMenuItem.Text = "Viewer";
            this.viewerToolStripMenuItem.Click += new System.EventHandler(this.viewerToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::BAMster.Properties.Resources.glyphicons_280_settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::BAMster.Properties.Resources.glyphicons_388_exit;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "HELP";
            // 
            // questionsToolStripMenuItem
            // 
            this.questionsToolStripMenuItem.Image = global::BAMster.Properties.Resources.glyphicons_194_circle_question_mark;
            this.questionsToolStripMenuItem.Name = "questionsToolStripMenuItem";
            this.questionsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.questionsToolStripMenuItem.Text = "Questions";
            this.questionsToolStripMenuItem.Click += new System.EventHandler(this.questionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::BAMster.Properties.Resources.glyphicons_195_circle_info;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.analysisTab);
            this.tabControl.Controls.Add(this.consoleTab);
            this.tabControl.Location = new System.Drawing.Point(2, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(578, 279);
            this.tabControl.TabIndex = 62;
            // 
            // analysisTab
            // 
            this.analysisTab.Controls.Add(this.featureBox);
            this.analysisTab.Controls.Add(this.msgLabel);
            this.analysisTab.Controls.Add(this.browseBtn);
            this.analysisTab.Controls.Add(this.sampleList);
            this.analysisTab.Location = new System.Drawing.Point(4, 26);
            this.analysisTab.Name = "analysisTab";
            this.analysisTab.Padding = new System.Windows.Forms.Padding(3);
            this.analysisTab.Size = new System.Drawing.Size(570, 249);
            this.analysisTab.TabIndex = 0;
            this.analysisTab.Text = "ANALYSIS";
            this.analysisTab.UseVisualStyleBackColor = true;
            // 
            // featureBox
            // 
            this.featureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.featureBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featureBox.ForeColor = System.Drawing.Color.Silver;
            this.featureBox.Location = new System.Drawing.Point(3, 218);
            this.featureBox.Name = "featureBox";
            this.featureBox.Size = new System.Drawing.Size(480, 25);
            this.featureBox.TabIndex = 59;
            this.featureBox.Text = "Feature file (*.bed, *.gtf, *.txt)";
            // 
            // sampleList
            // 
            this.sampleList.AllowDrop = true;
            this.sampleList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleList.ContextMenuStrip = this.sampleListMenu;
            this.sampleList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sampleList.FormattingEnabled = true;
            this.sampleList.HorizontalScrollbar = true;
            this.sampleList.ItemHeight = 17;
            this.sampleList.Location = new System.Drawing.Point(3, 4);
            this.sampleList.MinimumSize = new System.Drawing.Size(561, 208);
            this.sampleList.Name = "sampleList";
            this.sampleList.Size = new System.Drawing.Size(561, 208);
            this.sampleList.TabIndex = 60;
            this.sampleList.DragDrop += new System.Windows.Forms.DragEventHandler(this.sampleList_DragDrop);
            this.sampleList.DragEnter += new System.Windows.Forms.DragEventHandler(this.sampleList_DragEnter);
            // 
            // consoleTab
            // 
            this.consoleTab.Controls.Add(this.terminal);
            this.consoleTab.Location = new System.Drawing.Point(4, 26);
            this.consoleTab.Name = "consoleTab";
            this.consoleTab.Padding = new System.Windows.Forms.Padding(3);
            this.consoleTab.Size = new System.Drawing.Size(570, 249);
            this.consoleTab.TabIndex = 1;
            this.consoleTab.Text = "CONSOLE";
            this.consoleTab.UseVisualStyleBackColor = true;
            // 
            // terminal
            // 
            this.terminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terminal.IsInputEnabled = true;
            this.terminal.Location = new System.Drawing.Point(3, 3);
            this.terminal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.terminal.Name = "terminal";
            this.terminal.SendKeyboardCommandsToProcess = false;
            this.terminal.ShowDiagnostics = false;
            this.terminal.Size = new System.Drawing.Size(564, 243);
            this.terminal.TabIndex = 0;
            this.terminal.OnConsoleOutput += new ConsoleControl.ConsoleEventHanlder(this.terminal_OnConsoleOutput);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bamStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 343);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(580, 22);
            this.statusStrip.TabIndex = 63;
            this.statusStrip.Text = "statusStrip";
            // 
            // bamStatus
            // 
            this.bamStatus.BackColor = System.Drawing.SystemColors.Control;
            this.bamStatus.Name = "bamStatus";
            this.bamStatus.Size = new System.Drawing.Size(39, 17);
            this.bamStatus.Text = "Ready";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(580, 365);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.utilityBtn);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAMster - UTMDACC Molculer Diagnostic Laboratory";
            this.sampleListMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.analysisTab.ResumeLayout(false);
            this.analysisTab.PerformLayout();
            this.consoleTab.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseBtn;
        public System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.Button utilityBtn;
        private System.Windows.Forms.ContextMenuStrip sampleListMenu;
        private System.Windows.Forms.ToolStripMenuItem viewInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage analysisTab;
        private System.Windows.Forms.TabPage consoleTab;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel bamStatus;
        private ConsoleControl.ConsoleControl terminal;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewerToolStripMenuItem;
        private System.Windows.Forms.TextBox featureBox;
        private System.Windows.Forms.ListBox sampleList;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

