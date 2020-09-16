using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFZTrainer
{
    public partial class AboutForm : Form
    {

        static bool formOpen = false;

        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            if (!formOpen)
            {
                formOpen = true;
            }
            else
            {
                Dispose();
            }
        }

        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formOpen) formOpen = false;
        }

        private void btn_steam_Click(object sender, EventArgs e)
        {
            Process.Start("https://steamcommunity.com/profiles/76561198017577802");
        }

        private void btn_github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/HAWGT7");
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
