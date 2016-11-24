using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace MMManager.Controls
{
    class MMMDataGridView:System.Windows.Forms.DataGridView
    {
        private System.Drawing.Image _backgroundImage;
        public MMMDataGridView()
        {
            this._backgroundImage = Image.FromFile(@"C:\Projects\MMManager\MMManager\images\Copper.jpg");

        }
        protected override void PaintBackground(Graphics graphics, Rectangle clipBounds, Rectangle gridBounds)
        {
            base.PaintBackground(graphics, clipBounds, gridBounds);
            graphics.DrawImage(this._backgroundImage, gridBounds);
        }
        public Image BackgroundImage
        {
            get
            { return this._backgroundImage; }
            set { this._backgroundImage = value; }
        }
    }
}
