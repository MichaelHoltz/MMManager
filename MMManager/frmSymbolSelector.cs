using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMManager
{
    public partial class frmSymbolSelector : Form
    {
        public frmSymbolSelector()
        {
            InitializeComponent();
        }
        public int ImageSelected()
        {
            return btnSelect.ImageIndex;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (btnSelect.ImageIndex > 0)
            {
                this.Close();
            }
            //Cycle through images code
            //if (btnSelect.ImageIndex < btnSelect.ImageList.Images.Count - 1)
            //{
            //    btnSelect.ImageIndex++;
            //}
            //else
            //{
            //    btnSelect.ImageIndex = 0;
            //}
        }

        private void frmSymbolSelector_Load(object sender, EventArgs e)
        {
            int imageIndex = 0;
            foreach (var item in ilSelectButtons.Images)
            {
                if (imageIndex > 9)
                {
                    Button b = new Button();
                    b.Width = btnSelect.Width;
                    b.Height = btnSelect.Height;
                    b.ImageList = ilSelectButtons;
                    b.ImageIndex = imageIndex++;
                    b.Name = "Button" + b.ImageIndex;
                    b.Visible = true;
                    b.Click += B_Click;
                    flowLayoutPanel1.Controls.Add(b);
                }
                else
                {
                    imageIndex++; // Skip the first 10
                }
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            btnSelect.ImageIndex = (sender as Button).ImageIndex;
            //throw new NotImplementedException();
        }
    }
}
