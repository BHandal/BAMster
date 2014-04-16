using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAMster
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            guiBox.GotFocus += gui_RemoveText;
            guiBox.LostFocus += gui_AddText;
            apiBox.GotFocus += api_RemoveText;
            apiBox.LostFocus += api_AddText;
        }

        private void settings_Load(object sender, EventArgs e)
        {
            this.guiBox.Text = Properties.Settings.Default.bamstats_gui;
            this.apiBox.Text = Properties.Settings.Default.bamstats_api;
        }

        private void settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.bamstats_gui = this.guiBox.Text;
            Properties.Settings.Default.bamstats_api = this.apiBox.Text;
            Properties.Settings.Default.Save();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void guiBtn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JAR file|*.jar";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                guiBox.Text = ofd.FileName;
                this.guiBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
                this.guiBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void apibtn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JAR file|*.jar";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                apiBox.Text = ofd.FileName;
                this.apiBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
                this.apiBox.ForeColor = System.Drawing.Color.Black;
            }
        }
        public void gui_RemoveText(object sender, EventArgs e)
        {
            if (guiBox.Text == "GUI Jar file (*.jar)")
            {
                this.guiBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
                this.guiBox.ForeColor = System.Drawing.Color.Black;
                guiBox.Text = String.Empty;
            }
        }

        public void gui_AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(guiBox.Text))
            {
                guiBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Italic);
                guiBox.ForeColor = System.Drawing.Color.Silver;
                guiBox.Text = "GUI Jar file (*.jar)";
            }
        }
        public void api_RemoveText(object sender, EventArgs e)
        {
            if (apiBox.Text == "API Jar file (*.jar)")
            {
                this.apiBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
                this.apiBox.ForeColor = System.Drawing.Color.Black;
                apiBox.Text = String.Empty;
            }
        }

        public void api_AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(apiBox.Text))
            {
                apiBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Italic);
                apiBox.ForeColor = System.Drawing.Color.Silver;
                apiBox.Text = "API Jar file (*.jar)";
            }
        }
    }
}
