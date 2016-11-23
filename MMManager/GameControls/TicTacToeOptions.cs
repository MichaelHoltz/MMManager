using System;
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
        /// <summary>
        /// Option to Generate Bombs
        /// </summary>
        public bool GenerateBombs
        {
            get
            {
                foreach (var item in clbRandomOptions.CheckedItems)
                {
                    if (item.ToString() == "Bombs")
                        return true;
                }
                return false;
            }
        }
        public bool GenerateExtraTurns
        {
            get
            {
                foreach (var item in clbRandomOptions.CheckedItems)
                {
                    if (item.ToString() == "Extra Turns")
                        return true;
                }
                return false;
            }
        }

        public bool GenerateRowColClear
        {
            get
            {
                foreach (var item in clbRandomOptions.CheckedItems)
                {
                    if (item.ToString() == "Row / Col Clear")
                        return true;
                }
                return false;
            }
        }

        public bool GenerateShuffle
        {
            get
            {
                foreach (var item in clbRandomOptions.CheckedItems)
                {
                    if (item.ToString() == "Shuffle")
                        return true;
                }
                return false;
            }
        }


    }
}
