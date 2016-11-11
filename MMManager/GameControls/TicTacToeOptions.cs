using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMManager.GameInterfaces;
namespace MMManager.GameControls
{
    public partial class TicTacToeOptions : UserControl,IGameOptions
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
