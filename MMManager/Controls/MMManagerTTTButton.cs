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
        private bool autoFall;
        private string buttonBelow;
        private bool falling;
        private int newLocation;
        private int direction;
        public Boolean customEnable { get; set; } = true;
        public Boolean allowClick { get; set; } = true;

        /// <summary>
        /// Have button automatically Fall to the next button or bottom of container.
        /// </summary>
        public bool AutoFall
        {
            get
            {
                return autoFall;
            }

            set
            {
                autoFall = value;
                if (value)
                {
                    Fall(findButtonBelow());
                }
                else
                {

                }
            }
        }
        /// <summary>
        /// Get and Set the Button Below for use with auto falling.
        /// </summary>
        public string ButtonBelow
        {
            get
            {
                return buttonBelow;
            }

            set
            {
                buttonBelow = value;
            }
        }
        /// <summary>
        /// Set if the button is falling.
        /// </summary>
        public bool Falling
        {
            get
            {
                return falling;
            }

            set
            {
                falling = value;
            }
        }

        private int findButtonBelow()
        {
            var p = this.Parent;

            //GroupBox p = (this.Parent as GroupBox);
            if (p != null)
            {
                //Go through each sibling control
                foreach (var item in p.Controls)
                {
                    //If they are a MMMTTTButton
                    if (item.GetType() == typeof(MMManagerTTTButton))
                    {
                        //Ignore all who's Top is higher than me.
                        if ((item as MMManagerTTTButton).Top < this.Top)
                        {
                            return (item as MMManagerTTTButton).Top;
                        }
                    }
                }
            }
            return p.Height + this.Height; // Return the bottom.
        }

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
            nSprite.AnimateOnce(0);
            //nSprite.AnimateJustAFewTimes(1, 10);
        }
        public void ExplosionCompletes(object sender, EventArgs e)
        {
            Sprite tSprite = (Sprite)sender;
            tSprite.Destroy();
        }
        private void InitializeComponent()
        {
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
                        this.Falling = true;
                        SetTop(this.Top + direction);
                        Thread.Sleep(5);
                    }
                    else
                    {
                        break;
                    }
                } while (this.Top != newLocation);
                this.Falling = false;
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
