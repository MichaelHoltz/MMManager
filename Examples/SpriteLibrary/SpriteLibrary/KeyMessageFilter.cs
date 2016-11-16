using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteLibrary
{
    /// <summary>
    /// This is a delegate for a keypress event.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void SpriteKeyEventHandler(object sender, KeyEventArgs e);

    /// <summary>
    /// This is a system that can be used to find any keypress on a form.
    /// You want to define a variable on your form, something like:
    ///    private KeyMessageFilter the_filter = new KeyMessageFilter();
    /// When the form loads, set the filter with:
    ///    Application.AddMessageFilter(the_filter);
    ///   
    /// And then, to use it, do something like:
    ///   bool Up = m_filter.IsKeyPressed(Keys.W);
    ///   bool Down = m_filter.IsKeyPressed(Keys.S);
    ///   This code was found here: http://stackoverflow.com/questions/1100285/how-to-detect-the-currently-pressed-key
    /// </summary>
    internal class KeyMessageFilter : IMessageFilter
    {
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private bool m_keyPressed = false;

        
        public event SpriteKeyEventHandler KeyDown = delegate { };
        public event SpriteKeyEventHandler KeyUp = delegate { };

        private Dictionary<Keys, bool> m_keyTable = new Dictionary<Keys, bool>();

        public Dictionary<Keys, bool> KeyTable
        {
            get { return m_keyTable; }
            private set { m_keyTable = value; }
        }

        public bool IsKeyPressed()
        {
            return m_keyPressed;
        }

        public bool IsKeyPressed(Keys k)
        {
            bool pressed = false;

            if (KeyTable.TryGetValue(k, out pressed))
            {
                return pressed;
            }

            return false;
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_KEYDOWN)
            {
                KeyTable[(Keys)m.WParam] = true;
                KeyEventArgs e = new KeyEventArgs((Keys)m.WParam);
                KeyDown(null, e);
                m_keyPressed = true;
            }

            if (m.Msg == WM_KEYUP)
            {
                KeyTable[(Keys)m.WParam] = false;
                KeyEventArgs e = new KeyEventArgs((Keys)m.WParam);
                KeyUp(null, e);

                m_keyPressed = false;
            }

            return false;
        }

        public List<Keys> KeysPressed()
        {
            var answer = KeyTable.Where(kvp => kvp.Value== true).Select(kvp => kvp.Key);
            List<Keys> tList = new List<Keys>(answer);
            return tList;
        }
    }
}
