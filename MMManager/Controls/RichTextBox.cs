using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MMManager.Controls
{
    class RichTextBox:System.Windows.Forms.RichTextBox
    {
        public void AppendColorText(string text, Color color)
        {

            int start = this.TextLength;
            this.AppendText(text);
            int end = this.TextLength;
            this.Select(start, end - start);
            //Can set other selected properties here
            SelectionColor = color;
            SelectionLength = 0;
            SelectionStart = TextLength;
            ScrollToCaret();
        }
    }
}
