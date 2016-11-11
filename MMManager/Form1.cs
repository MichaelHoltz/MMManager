using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace MMManager
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void ticTacToeBoard1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ticTacToeBoard1.PlayerName = tbUserName.Text.Trim();
            //this.ticTacToeBoard1.setPlayerName(tbUserName.Text.Trim());
        }
    }
}
