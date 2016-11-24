using System;
using System.Windows.Forms;
//using System.Media;
using System.Threading;
using System.Windows.Media;
namespace MMManager
{
    class MMManagerTTTButton :Button
    {
        private int newLocation;
        private int direction;
        public Boolean customEnable { get; set; } = true;
        public Boolean allowClick { get; set; } = true;
        protected override void OnClick(EventArgs e)
        {
            if (customEnable && allowClick)
            {
                base.OnClick(e);
            }
            else
            {
                playSound(1);
            }
        }
        private void playSound(int sound)
        {
            MediaPlayer mp = new System.Windows.Media.MediaPlayer();
            string currentDir = System.IO.Directory.GetCurrentDirectory() + @"\Sounds\";
            if (sound == 1)
            {
                mp.Open(new System.Uri(currentDir + @"Blop.wav"));
            }
            if (sound == 3)
            {
                mp.Open(new System.Uri(currentDir + @"Woosh.wav"));
            }
            if (sound == 2)
            {
                mp.Open(new System.Uri(currentDir + @"Woosh.wav"));
                mp.SpeedRatio = 2.5;
            }
            mp.Play();



        }
        private void InitializeComponent()
        {
            this.DoubleBuffered = true;
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
        public void Fall(int distance)
        {
            newLocation = this.Top + distance; // Where we want to be
            direction = +1;
            Thread thread = new Thread(new ThreadStart(WorkThreadFunction));
            thread.Start();
        }
        public void Rise(int distance)
        {
            newLocation = this.Top - distance; // Where we want to be
            direction = -1;
            Thread thread = new Thread(new ThreadStart(WorkThreadFunction));
            thread.Start();
        }

        private void WorkThreadFunction()
        {
            int oldTop = this.Top;
            try
            {
                do
                {
                    if (this.Top + direction > 0 && ((this.Top + this.Height + direction) < Parent.Height ))
                    {
                        SetTop(this.Top + direction);
                        Thread.Sleep(5);
                    }
                    else
                    {
                        break;
                    }
                } while (this.Top != newLocation);
                playSound(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        delegate void SetTopCallback(int location);
        private void SetTop(int location)
        {
            if (this.InvokeRequired)
            {
                SetTopCallback d = new SetTopCallback(SetTop);
                this.Invoke(d, new object[] { location });
            }
            else
            {
                this.Top = location;
            }
        }
    }
}
