using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g14boost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            form.Opacity = 0;
            form.ShowInTaskbar = false;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new System.Drawing.Point(-2000, -2000);
            form.Size = new System.Drawing.Size(1, 1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void settingsStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            var res = settingsForm.ShowDialog();
            if (res == DialogResult.OK)
            {

            }
            settingsForm.Dispose();
        }
    }
}
