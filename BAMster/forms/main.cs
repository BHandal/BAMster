using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BAMster
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            featureBox.GotFocus += RemoveText;
            featureBox.LostFocus += AddText;
        }

        #region buttons
        StringBuilder doesnotexist;
        StringBuilder args;
        StringBuilder samps;
        private void executeBtn_Click(object sender, EventArgs e)
        {
            if (executeBtn.Text.ToLower() == "analyze")
            {
                if (File.Exists(featureBox.Text))
                {
                    //analyze samples
                    doesnotexist = new StringBuilder();
                    args = new StringBuilder();
                    samps = new StringBuilder();
                    int i = 1;
                    foreach (string path in sampleList.Items)
                    {
                        
                        if (!File.Exists(path + "_bamster.csv"))
                        {
                            if (File.Exists(path))
                            {
                                string fn = Path.GetFileNameWithoutExtension(path);
                                args.Append("java -Xmx8g -jar " + @"""" + Properties.Settings.Default.bamstats_api + @"""" + " -v simple -m -f " + @"""" + featureBox.Text + @"""" + " -i " + @"""" + path + @"""" + " -o " + @"""" + path + "_bamster.csv" + @"""" + " & ");
                                samps.AppendLine(i+".) "+fn);
                                i++;
                            }
                            else
                            {
                                doesnotexist.Append("-" + path + Environment.NewLine);
                            }
                        }
                    }

                    if (doesnotexist.Length <= 0)
                    {
                        if (File.Exists(Properties.Settings.Default.bamstats_api))
                        {
                            DialogResult dialogResult = MessageBox.Show("Ready to start analysis?" + Environment.NewLine + Environment.NewLine + "Samples:" + Environment.NewLine + samps.ToString(), "BAMster - Checkpoint", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.Yes)
                            {
                                tabControl.SelectedTab = consoleTab;
                                terminal.ClearOutput();
                                executeBtn.Text = "CANCEL";
                                bamStatus.Text = "Analyzing...";

                                terminal.StartProcess("cmd.exe", @"/C " + args.ToString(0, args.Length - 2));
                            }
                            else { dialogResult = DialogResult.Cancel; }
                        }
                        else
                        {
                            MessageBox.Show("The API Jar file does not exist: " + Environment.NewLine + Environment.NewLine + Properties.Settings.Default.bamstats_api, "BAMster - File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            using (settings setDialog = new settings())
                            {
                                setDialog.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input contains file(s) that do not exist, see below:" + Environment.NewLine + doesnotexist.ToString(0, doesnotexist.Length - 1), "BAMster - 404 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please select a valid bed file.", "BAMster - 404 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if (executeBtn.Text.ToLower() == "cancel")
            {
                bamStatus.Text = "Cancelled!";
                terminal.StopProcess();
                //cancel analysis
                executeBtn.Text = "ANALYZE";

            }
        }
        private void utilityBtn_Click(object sender, EventArgs e)
        {
            this.sampleList.Items.Clear();
            this.terminal.ClearOutput();
            default1();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void browseBtn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "BED file|*.bed|GTF file|*.gtf|Text file|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                featureBox.Text = ofd.FileName;
                this.featureBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
                this.featureBox.ForeColor = System.Drawing.Color.Black;
            }
        }
        #endregion

        #region menus
        Process cmdProcess;
        private void viewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists(Properties.Settings.Default.bamstats_gui))
            {
                cmdProcess = new Process();
                cmdProcess.StartInfo.FileName = "cmd.exe";
                cmdProcess.StartInfo.Arguments = @"/C java -Xmx8g -jar " + @" """ + Properties.Settings.Default.bamstats_gui + @"""";
                cmdProcess.StartInfo.UseShellExecute = true;
                cmdProcess.StartInfo.CreateNoWindow = false;
                cmdProcess.StartInfo.RedirectStandardOutput = false;
                cmdProcess.Start();
            }
            else
            {
                MessageBox.Show("The GUI Jar file does not exist: /r/n/n"+Properties.Settings.Default.bamstats_gui,"BAMster - File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (settings setDialog = new settings())
                {
                    setDialog.ShowDialog();
                }
            }
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (settings setDialog = new settings())
            {
                setDialog.ShowDialog();
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Brian Handal" + Environment.NewLine + "(BHandal@mdanderson.org)", "About BAMster", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void questionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're on your own!", "BAMster is sorry...", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void viewInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sampleList.SelectedIndex > -1)
            {
                if (File.Exists(sampleList.SelectedItem.ToString()))
                {
                    string args = string.Format(@"/select, {0}", sampleList.SelectedItem.ToString());
                    ProcessStartInfo pfi = new ProcessStartInfo("Explorer.exe", args);
                    System.Diagnostics.Process.Start(pfi);
                }
                else
                {
                    MessageBox.Show("File not found.", "BAMster - 404 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sampleList.SelectedIndex > -1)
            {
                sampleList.Items.Remove(sampleList.SelectedItem);
            }
            if (sampleList.Items.Count <= 0)
            {
                default1();
            }
        }
        #endregion

        #region drag/drop
        private void sampleList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                foreach (string file in files)
                {
                    string ext = Path.GetExtension(file);
                    string filepath = file;
                    if (ext == ".bam" || ext == ".sam")
                    {
                        if (!File.Exists(filepath + "_bamster.csv"))
                        {
                            default2();
                            if (!sampleList.Items.Contains(filepath))
                            {
                                sampleList.Items.Add(filepath);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Analysis has already been performed on " + Path.GetFileName(file), "BAMster - File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }    
                    }
                    else
                    {
                        MessageBox.Show(Path.GetFileName(file) + " is not a BAM or SAM file.", "BAMster - File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void sampleList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;

            else
                e.Effect = DragDropEffects.None;
        }
        #endregion

        #region misc
        
        private void default1()
        {
            this.msgLabel.Visible = true;
            this.utilityBtn.Enabled = false;
            this.executeBtn.Enabled = false;
        }
        private void default2()
        {
            this.msgLabel.Visible = false;
            this.utilityBtn.Enabled = true;
            this.executeBtn.Enabled = true;
        }
        public void RemoveText(object sender, EventArgs e)
        {
            if (featureBox.Text == "Feature file (*.bed, *.gtf, *.txt)" )
            {
                this.featureBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
                this.featureBox.ForeColor = System.Drawing.Color.Black;
                featureBox.Text = String.Empty;
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(featureBox.Text))
            {
                featureBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Italic);
                featureBox.ForeColor = System.Drawing.Color.Silver;
                featureBox.Text = "Feature file (*.bed, *.gtf, *.txt)";
            }
        }
        private void terminal_OnConsoleOutput(object sender, ConsoleControl.ConsoleEventArgs args)
        {
            if (!terminal.IsProcessRunning)
            {
                bamStatus.Text = "Ready";
                executeBtn.Text = "ANALYZE";
                terminal.WriteOutput(Environment.NewLine + "Analysis has completed.", Color.White);
            }
        }
        #endregion
    }
}
