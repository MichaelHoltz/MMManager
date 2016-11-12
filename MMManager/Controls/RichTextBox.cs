using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MMManager.Controls
{
    class RichTextBox:System.Windows.Forms.RichTextBox
    {
        private delegate void AppendColorTextCallback(string text, Color color);
        public void AppendColorText(string text, Color color)
        {

            if (this.InvokeRequired)
            {
                AppendColorTextCallback d = new AppendColorTextCallback(AppendColorText);
                this.Invoke(d, new object[] { text, color });

            }
            else
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

}
