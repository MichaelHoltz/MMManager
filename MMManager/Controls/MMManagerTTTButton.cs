using System;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Media;
using System.Drawing;
using SpriteLibrary;
namespace MMManager
{
    public enum SpriteNames { shot, spaceship, explosion, jelly, dragon, walker, flier, GreyButton }
    class MMManagerTTTButton :Button
    {
        private PictureBox MainDrawingArea;
        MediaPlayer mp;
        SpriteController MySpriteController;
        Sprite OneSprite;
        public int myGridX;
        public int myGridY;
        public int maxGridX;
        public int maxGridY;
        private int newLocation;
        private ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
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
        delegate void playSoundCallback(int sound);
        private void playSound(int sound)
        {
            if (this.InvokeRequired)
            {
                SetTopCallback d = new SetTopCallback(playSound);
                this.Invoke(d, new object[] { sound });
            }
            else
            {
                string currentDir = System.IO.Directory.GetCurrentDirectory() + @"\Sounds\";
                if (sound == 1)
                {
                    mp.Open(new System.Uri(currentDir + @"Blop.wav"));
                }
                if (sound == 2)
                {
                    mp.Open(new System.Uri(currentDir + @"Woosh.wav"));
                    mp.SpeedRatio = 2.5;
                }
                if (sound == 3)
                {
                    mp.Open(new System.Uri(currentDir + @"Woosh.wav"));
                }
                if (sound == 4)
                {
                    mp.Open(new System.Uri(currentDir + @"Bomb_Exploding.wav"));
                    mp.SpeedRatio = 2.5;
                }
                
                mp.Play();
            }



        }
        public MMManagerTTTButton()
        {
            InitializeComponent();
            mp = new System.Windows.Media.MediaPlayer();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            this.ResumeLayout(false);

        }
        public void ToolTip(string tip)
        {
            this.toolTip1.SetToolTip(this, tip);
        }
        /// <summary>
        /// Turns the Button into a picture.. If doing this from clicking the button itself it will have the being clicked effect.
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Bitmap TurnToPicture()
        {
            MainDrawingArea = new PictureBox();
            MainDrawingArea.Top = 0;// this.Top;
            MainDrawingArea.Left = 0;// this.Left;
            MainDrawingArea.Height = this.Height;
            MainDrawingArea.Width = this.Width;
            MainDrawingArea.BackgroundImageLayout = ImageLayout.Stretch;
            //MainDrawingArea.SizeMode = PictureBoxSizeMode.StretchImage;
            System.Drawing.Bitmap thisButtonBitmap = new System.Drawing.Bitmap(this.Width, this.Height);
            this.DrawToBitmap(thisButtonBitmap, new System.Drawing.Rectangle(0,0,this.Width, this.Height));
            MainDrawingArea.BackgroundImage = thisButtonBitmap;
            this.Controls.Add(MainDrawingArea);
            MainDrawingArea.Visible = true;

            //Create Animation for Explosion
            MySpriteController = new SpriteController(MainDrawingArea);
            OneSprite = new Sprite(MySpriteController, Properties.Resources.explode, 50, 50, 50);
            OneSprite.SetSize(new Size(50, 50));
            OneSprite.SetName(SpriteNames.explosion.ToString());
            ////The function to run when the explosion animation completes
            OneSprite.SpriteAnimationComplete += ExplosionCompletes;


            Sprite nSprite = MySpriteController.DuplicateSprite(SpriteNames.explosion.ToString());
            nSprite.PutBaseImageLocation(0, 0);
            nSprite.SetSize(new Size(50, 50));

            nSprite.AnimateOnce(0);


            

            return thisButtonBitmap;
        }

        public void explode()
        {
            timer1.Enabled = true;
        }

        /// <summary>
        /// This will take a button out of the grid and put it on top, pushing all that were above down one.
        /// This re-arranges the actual buttons in the grid so reference by name is all that is accurate once an explosion has happened.
        /// </summary>
        private void explode2()
        {
         
            this.ImageIndex = 0;
            ////The function to run when the explosion animation completes
            //Sprite nSprite = MySpriteController.DuplicateSprite(SpriteNames.explosion.ToString());
            //nSprite.PutBaseImageLocation(-1, -1);
            //nSprite.SetSize(new Size(50, 50));
            ////  nSprite.AnimateOnce(0);
            //nSprite.AnimateJustAFewTimes(1, 10);
            //this.Name = "B-1" + this.myGridX; // Temporarally rename
            //this.SendToBack();
            for (int i = this.myGridY - 1; i >= 0; i--) // Each Button Above this from closest to farthest
            {
                MMManagerTTTButton bAbove = this.Parent.Controls.Find("B" + i + this.myGridX, false)[0] as MMManagerTTTButton;
                bAbove.myGridY++; // Add one to it's Y Posistion
                bAbove.Name = "B" + bAbove.myGridY + bAbove.myGridX; // Rename

                bAbove.FallToNextButton();
                //Thread.Sleep(50);
                // Application.DoEvents();

            }
            this.myGridY = 0; //Set to Top Most position off screen.
            this.Name = "B0" + this.myGridX;
            this.Top = this.Height * -1; // -50; // Instantly move off screen (After doing animation
            this.FallToNextButton();
            this.ToolTip(this.Name + " [" + this.myGridY + "," + this.myGridX + "]");

        }
        public void ExplosionCompletes(object sender, EventArgs e)
        {
            Sprite tSprite = (Sprite)sender;
            tSprite.Destroy();
            
            this.Controls.Remove(MainDrawingArea);
            timer2.Enabled = true;  //Start Falling
            MainDrawingArea = null; // REmove the picture
            // CountMonsters();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.TurnToPicture();
            //Create Animation for Explosion
            MySpriteController = new SpriteController(MainDrawingArea);
            OneSprite = new Sprite(MySpriteController, Properties.Resources.explode, 50, 50, 50);
            OneSprite.SetSize(new Size(50, 50));
            OneSprite.SetName(SpriteNames.explosion.ToString());
            ////The function to run when the explosion animation completes
            OneSprite.SpriteAnimationComplete += ExplosionCompletes;


            Sprite nSprite = MySpriteController.DuplicateSprite(SpriteNames.explosion.ToString());
            nSprite.PutBaseImageLocation(0, 0);
            nSprite.SetSize(new Size(50, 50));

            playSound(4); // Explosion Sound
            nSprite.AnimateOnce(0);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            explode2();

        }

        private void setGridY(MMManagerTTTButton btn)
        {
            if (btn.myGridY + 1 < btn.maxGridY)
            {
                btn.myGridY++;
            }
            else
            {
                btn.myGridY = 0;
            }

        }
        public void FallToNextButton()
        {
            newLocation = (this.myGridY * this.Height) + 20; //Next "Quantum" location
            if (newLocation > this.Top) //Need to move
            {
                this.ToolTip(this.Name + " [" + this.myGridY + "," + this.myGridX + "]");
                direction = +1;
                Thread thread = new Thread(new ThreadStart(MovementThread));
                thread.Start();
            }
            return;
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
                    if ( (this.Top + this.Height + direction) < Parent.Height )
                    {
                        SetTop(this.Top + direction);
                        Thread.Sleep(5);
                    }
                    else
                    {
                        break;
                    }
                } while (this.Top != newLocation );
                if (oldTop != this.Top)
                {
                    playSound(2);
                    if (this.ImageIndex == 1)
                    {
                        this.ImageIndex = 0; // Remove bombs
                    }
                }
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
