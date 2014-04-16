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
            this.viewSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.resultTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.resultList = new System.Windows.Forms.ListBox();
            this.resultListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewResultStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteResultStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.bamStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.sampleListMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.analysisTab.SuspendLayout();
            this.consoleTab.SuspendLayout();
            this.resultTab.SuspendLayout();
            this.resultListMenu.SuspendLayout();
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
            this.viewSampleToolStripMenuItem,
            this.deleteSampleToolStripMenuItem});
            this.sampleListMenu.Name = "sampleListMenu";
            this.sampleListMenu.Size = new System.Drawing.Size(158, 48);
            // 
            // viewSampleToolStripMenuItem
            // 
            this.viewSampleToolStripMenuItem.Image = global::BAMster.Properties.Resources.glyphicons_389_new_window_alt;
            this.viewSampleToolStripMenuItem.Name = "viewSampleToolStripMenuItem";
            this.viewSampleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewSampleToolStripMenuItem.Text = "View in explorer";
            this.viewSampleToolStripMenuItem.Click += new System.EventHandler(this.viewSampleToolStripMenuItem_Click);
            // 
            // deleteSampleToolStripMenuItem
            // 
            this.deleteSampleToolStripMenuItem.Image = global::BAMster.Properties.Resources.glyphicons_016_bin;
            this.deleteSampleToolStripMenuItem.Name = "deleteSampleToolStripMenuItem";
            this.deleteSampleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteSampleToolStripMenuItem.Text = "Delete";
            this.deleteSampleToolStripMenuItem.Click += new System.EventHandler(this.deleteSampleToolStripMenuItem_Click);
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
            this.executeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            this.viewerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.viewerToolStripMenuItem.Text = "Viewer";
            this.viewerToolStripMenuItem.Click += new System.EventHandler(this.viewerToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::BAMster.Properties.Resources.glyphicons_280_settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::BAMster.Properties.Resources.glyphicons_388_exit;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
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
            this.tabControl.Controls.Add(this.resultTab);
            this.tabControl.Location = new System.Drawing.Point(2, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(578, 279);
            this.tabControl.TabIndex = 62;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
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
            this.sampleList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sampleList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleList.FormattingEnabled = true;
            this.sampleList.HorizontalScrollbar = true;
            this.sampleList.ItemHeight = 17;
            this.sampleList.Location = new System.Drawing.Point(3, 4);
            this.sampleList.MinimumSize = new System.Drawing.Size(561, 208);
            this.sampleList.Name = "sampleList";
            this.sampleList.Size = new System.Drawing.Size(561, 208);
            this.sampleList.TabIndex = 60;
            this.sampleList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.sampleList_DrawItem);
            this.sampleList.DragDrop += new System.Windows.Forms.DragEventHandler(this.sampleList_DragDrop);
            this.sampleList.DragEnter += new System.Windows.Forms.DragEventHandler(this.sampleList_DragEnter);
            this.sampleList.DoubleClick += new System.EventHandler(this.sampleList_DoubleClick);
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
            // resultTab
            // 
            this.resultTab.Controls.Add(this.label1);
            this.resultTab.Controls.Add(this.resultList);
            this.resultTab.Location = new System.Drawing.Point(4, 26);
            this.resultTab.Name = "resultTab";
            this.resultTab.Padding = new System.Windows.Forms.Padding(3);
            this.resultTab.Size = new System.Drawing.Size(570, 249);
            this.resultTab.TabIndex = 2;
            this.resultTab.Text = "RESULTS";
            this.resultTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(196, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 62;
            this.label1.Text = "No data present...";
            // 
            // resultList
            // 
            this.resultList.AllowDrop = true;
            this.resultList.ContextMenuStrip = this.resultListMenu;
            this.resultList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.resultList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultList.FormattingEnabled = true;
            this.resultList.HorizontalExtent = 1;
            this.resultList.HorizontalScrollbar = true;
            this.resultList.ItemHeight = 17;
            this.resultList.Location = new System.Drawing.Point(3, 3);
            this.resultList.MinimumSize = new System.Drawing.Size(561, 208);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(564, 243);
            this.resultList.TabIndex = 61;
            this.resultList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.resultList_DrawItem);
            this.resultList.DoubleClick += new System.EventHandler(this.resultList_DoubleClick);
            // 
            // resultListMenu
            // 
            this.resultListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewResultStripMenuItem,
            this.deleteResultStripMenuItem});
            this.resultListMenu.Name = "sampleListMenu";
            this.resultListMenu.Size = new System.Drawing.Size(158, 48);
            // 
            // viewResultStripMenuItem
            // 
            this.viewResultStripMenuItem.Image = global::BAMster.Properties.Resources.glyphicons_389_new_window_alt;
            this.viewResultStripMenuItem.Name = "viewResultStripMenuItem";
            this.viewResultStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewResultStripMenuItem.Text = "View in explorer";
            this.viewResultStripMenuItem.Click += new System.EventHandler(this.viewResultStripMenuItem_Click);
            // 
            // deleteResultStripMenuItem
            // 
            this.deleteResultStripMenuItem.Image = global::BAMster.Properties.Resources.glyphicons_016_bin;
            this.deleteResultStripMenuItem.Name = "deleteResultStripMenuItem";
            this.deleteResultStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteResultStripMenuItem.Text = "Delete";
            this.deleteResultStripMenuItem.Click += new System.EventHandler(this.deleteResultStripMenuItem_Click);
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
            this.AcceptButton = this.executeBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.executeBtn;
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
            this.resultTab.ResumeLayout(false);
            this.resultTab.PerformLayout();
            this.resultListMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem viewSampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSampleToolStripMenuItem;
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
        private System.Windows.Forms.TabPage resultTab;
        private System.Windows.Forms.ListBox resultList;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip resultListMenu;
        private System.Windows.Forms.ToolStripMenuItem viewResultStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteResultStripMenuItem;
    }
}

