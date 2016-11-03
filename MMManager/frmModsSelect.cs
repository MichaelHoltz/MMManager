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
    public partial class frmModsSelect : Form
    {
        public frmModsSelect()
        {
            InitializeComponent();
        }

        private void cbMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO Look up Mod Information from Selection.
            lblModInfo.Text = cbMods.Text;

            //TODO display the State.
            if (cbMods.CheckedItems.Contains(cbMods.SelectedItem))
            {
                lblModState.Text = "Enabled";
            }
            else 
            {
                lblModState.Text = "Disabled";
            }
        }
    }
}
