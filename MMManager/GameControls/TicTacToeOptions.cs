using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMManager.GameControls
{
    public partial class TicTacToeOptions : UserControl
    {
        public TicTacToeOptions()
        {
            InitializeComponent();
        }
        /// <summary>
        /// GridSize Property
        /// </summary>
        public int GridSize
        {
            get
            {
                return Convert.ToInt32(domainUpDown1.Text);
            }
        }
    }
}
