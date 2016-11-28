using System;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Media;
using System.Drawing;
using SpriteLibrary;
namespace MMManager
{
    public enum SpriteNames { shot, spaceship, explosion, jelly, dragon, walker, flier }
    class MMManagerTTTButton :Button
    {
        SpriteController MySpriteController;
        Sprite OneSprite;
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
        public MMManagerTTTButton()
        {
            InitializeComponent();
             
        }

        public System.Drawing.Bitmap TurnToPicture()
        {
            PictureBox MainDrawingArea = new PictureBox();
            MainDrawingArea.Top = 0;// this.Top;
            MainDrawingArea.Left = 0;// this.Left;
            MainDrawingArea.Height = this.Height;
            MainDrawingArea.Width = this.Width;
            
            System.Drawing.Bitmap thisButtonBitmap = new System.Drawing.Bitmap(this.Width, this.Height);
            this.DrawToBitmap(thisButtonBitmap, new System.Drawing.Rectangle(0,0,this.Width, this.Height));
            MainDrawingArea.BackgroundImage = thisButtonBitmap;
            this.Controls.Add(MainDrawingArea);
            MainDrawingArea.Visible = true;

            //MySpriteController = new SpriteController(MainDrawingArea);
            //OneSprite = new Sprite(MySpriteController, Properties.Resources.explode, 50, 50, 50);
            //OneSprite.SetSize(new Size(50, 50));
            //OneSprite.SetName(SpriteNames.explosion.ToString());
            ////The function to run when the explosion animation completes
            //OneSprite.SpriteAnimationComplete += ExplosionCompletes;

            return thisButtonBitmap;
        }
        public void explode()
        {
            //The function to run when the explosion animation completes
            Sprite nSprite = MySpriteController.DuplicateSprite(SpriteNames.explosion.ToString());
            nSprite.PutBaseImageLocation(-1, -1);
            nSprite.SetSize(new Size(50, 50));
            //  nSprite.AnimateOnce(0);
            nSprite.AnimateJustAFewTimes(1, 10);
        }
        public void ExplosionCompletes(object sender, EventArgs e)
        {
            Sprite tSprite = (Sprite)sender;
            tSprite.Destroy();
           // CountMonsters();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
        /// <summary>
        /// Fall a distance relative to current position by Thread
        /// </summary>
        /// <param name="distance"></param>
        public void Fall(int distance)
        {
            newLocation = this.Top + distance; // Where we want to be
            direction = +1;
            Thread thread = new Thread(new ThreadStart(MovementThread));
            thread.Start();
        }
        /// <summary>
        /// Rise a distance relative to current position by Thread
        /// </summary>
        /// <param name="distance"></param>
        public void Rise(int distance)
        {
            newLocation = this.Top - distance; // Where we want to be
            direction = -1;
            Thread thread = new Thread(new ThreadStart(MovementThread));
            thread.Start();
        }
        /// <summary>
        /// Thread to manage movement
        /// Movement is designed to be animated
        /// </summary>
        private void MovementThread()
        {
            int oldTop = this.Top;
            try
            {
                //Move to new location in small steps.
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

        /// <summary>
        /// Delegate for Setting the Top location
        /// </summary>
        /// <param name="location"></param>
        delegate void SetTopCallback(int location);
        /// <summary>
        /// Set the absolute top location - Thread Safe
        /// </summary>
        /// <param name="location"></param>
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
