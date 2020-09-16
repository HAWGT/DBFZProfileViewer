using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFZTrainer
{
    public partial class HelpForm : Form
    {

        static bool formOpen = false;

        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            if (!formOpen)
            {
                formOpen = true;
            } else
            {
                Dispose();
            }
        }

        private void HelpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formOpen) formOpen = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
