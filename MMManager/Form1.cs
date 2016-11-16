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



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            ticTacToeBoard1.PlayerName = tbUserName.Text.Trim();
            ticTacToeBoard1.GameInfo.Player.PlayerName = tbUserName.Text.Trim(); // Assign Player Name when Logging in.

            ticTacToeBoard1.GameInfo.GameName = tbUserName.Text.Trim() + "'s Game"; // Default to something.. but will be overwritten in GameInfo if needed.
            
            //this.ticTacToeBoard1.setPlayerName(tbUserName.Text.Trim());
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Bitmap bm;
            using (bm = new Bitmap(ticTacToeBoard1.Width, ticTacToeBoard1.Height))
            {
                ticTacToeBoard1.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
                bm.Save(@"c:\MMManager\tictacToeBoard.png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
