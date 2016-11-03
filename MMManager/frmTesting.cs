using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.PeerToPeer;

namespace MMManager
{
    public partial class frmTesting : Form
    {
        public frmTesting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                label1.Text = openFileDialog1.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
