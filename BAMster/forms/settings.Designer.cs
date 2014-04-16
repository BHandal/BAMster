namespace BAMster
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.guiBtn = new System.Windows.Forms.Button();
            this.apibtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guiBox = new System.Windows.Forms.TextBox();
            this.apiBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guiBtn
            // 
            this.guiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guiBtn.Location = new System.Drawing.Point(479, 30);
            this.guiBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guiBtn.Name = "guiBtn";
            this.guiBtn.Size = new System.Drawing.Size(87, 25);
            this.guiBtn.TabIndex = 3;
            this.guiBtn.Text = "BROWSE";
            this.guiBtn.UseVisualStyleBackColor = true;
            this.guiBtn.Click += new System.EventHandler(this.guiBtn_Click);
            // 
            // apibtn
            // 
            this.apibtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apibtn.Location = new System.Drawing.Point(479, 89);
            this.apibtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.apibtn.Name = "apibtn";
            this.apibtn.Size = new System.Drawing.Size(87, 25);
            this.apibtn.TabIndex = 5;
            this.apibtn.Text = "BROWSE";
            this.apibtn.UseVisualStyleBackColor = true;
            this.apibtn.Click += new System.EventHandler(this.apibtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Location of the graphical user interface (GUI) of BAMStats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Location of the command line API of BAMStats";
            // 
            // guiBox
            // 
            this.guiBox.Location = new System.Drawing.Point(12, 31);
            this.guiBox.Name = "guiBox";
            this.guiBox.Size = new System.Drawing.Size(461, 25);
            this.guiBox.TabIndex = 9;
            // 
            // apiBox
            // 
            this.apiBox.Location = new System.Drawing.Point(13, 90);
            this.apiBox.Name = "apiBox";
            this.apiBox.Size = new System.Drawing.Size(460, 25);
            this.apiBox.TabIndex = 10;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(578, 124);
            this.Controls.Add(this.apiBox);
            this.Controls.Add(this.guiBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apibtn);
            this.Controls.Add(this.guiBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAMster - Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settings_FormClosing);
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guiBtn;
        private System.Windows.Forms.Button apibtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox guiBox;
        private System.Windows.Forms.TextBox apiBox;
    }
}