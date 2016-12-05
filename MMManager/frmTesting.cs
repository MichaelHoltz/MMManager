using System;
using System.Drawing;
using System.Windows.Forms;
using MMManager.GameObjects;
using System.Threading;
using SpriteLibrary;
using System.Windows.Media;
namespace MMManager
{
    public partial class frmTesting : Form
    {
        private MediaPlayer mp;
        SpriteController MySpriteController;
        private int[,] grid;
        private SharedTicTacToeBoardData _stttbd;
        private MMManagerTTTButton theButton; //Shared Button Object
        private MMManagerTTTButton[,] b;
        Sprite OneSprite, Explode, pacMan, player, Jack, Coin;
        public frmTesting()
        {
            InitializeComponent();
            mp = new MediaPlayer();
        }
        delegate void playSoundCallback(int sound);
        private void playSound(int sound)
        {
            if (this.InvokeRequired)
            {
                playSoundCallback d = new playSoundCallback(playSound);
                this.Invoke(d, new object[] { sound });
            }
            else
            {
                string currentDir = System.IO.Directory.GetCurrentDirectory() + @"\Sounds\";
                if (sound == 1)
                {
                    mp.Open(new System.Uri(currentDir + @"PacMan_Fast.mp3"));
                    mp.MediaEnded += PacManEnded;
                }
                if (sound == 2)
                {
                    mp.Open(new System.Uri(currentDir + @"PacMan_Slow.mp3"));
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

        private void PacManEnded(object sender, EventArgs e)
        {
            (sender as MediaPlayer).Position = new TimeSpan();
            (sender as MediaPlayer).Play();
            
        }

        private void frmTesting_Load(object sender, EventArgs e)
        {
            
            MySpriteController = new SpriteController(pbBackGround);
            OneSprite = new Sprite(MySpriteController, Properties.Resources.GreyButton, 50, 50, 0);
            OneSprite.SetSize(new Size(50, 50));
            OneSprite.SetName(SpriteNames.GreyButton.ToString());

            player = new Sprite(MySpriteController, _ButtonImageList.Images[20], 100, 100); // Player
            player.SetSize(new Size(50, 50)); // Not sure about size here.
            player.SetName("player1");


            Explode = new Sprite(MySpriteController, Properties.Resources.explode, 50, 50, 40);
            Explode.SetSize(new Size(50, 50));
            Explode.SetName(SpriteNames.explosion.ToString());
            Explode.SpriteAnimationComplete += ExplosionCompletes;

            pacMan = new Sprite(MySpriteController, Properties.Resources.PacMan, 50, 50, 100);
            pacMan.SetSize(new Size(40, 40));
            pacMan.SetName("pacMan");
            pacMan.Zvalue = 55;

            //Jack = new Sprite(MySpriteController, Properties.Resources.Jack_skellington_sprite_486cc8057e65df417413fdbc89b68a78, 265, 389, 10);
            //Jack.SetSize(new Size(132, 194));
            //Jack.SetName("Jack");

            Coin = new Sprite(MySpriteController, Properties.Resources.Coin, 100, 100, 50);
            Coin.SetSize(new Size(50, 50));
            Coin.SetName("Coin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                label1.Text = openFileDialog1.FileName;
            }

        }
        /// <summary>
        /// Temporary Copy of what is used in the actual game - just here for testing Buttons.
        /// </summary>
        /// <param name="sharedTicTacToeBoardData"></param>
        /// <returns></returns>
        private SharedTicTacToeBoardData GenerateGameButtons(SharedTicTacToeBoardData sharedTicTacToeBoardData)
        {
            int maxX = 3; // Convert.ToInt32(sharedTicTacToeBoardData.GameSize);
            int maxY = maxX; // Keep Symetry
            sharedTicTacToeBoardData.GameBoard = new int[maxX * maxY];
            int y = 0;
            int x = 0;
            int index = 0;


            b = new MMManagerTTTButton[maxY, maxX]; //2d array of buttons.
            grid = new int[maxY, maxX];

            for (y = 0; y < maxY; y++)
            {
                for (x = 0; x < maxX; x++)
                {
                    b[y, x] = new MMManagerTTTButton();
                    b[y, x].Name = "B" + y + x;
                    b[y, x].Font = new Font("Microsoft Sans Serif", 12);
                    b[y, x].Text = index.ToString(); // String.Empty;                     //Clear Button
                    b[y, x].ImageIndex = 0;                         //Clear Images
                    sharedTicTacToeBoardData.GameBoard[index++] = 0; //Clear 1d Grid
                    grid[y, x] = 0;                                  //Clear 2d Grid
                    b[y, x].Tag = "0";
                    b[y, x].Width = 50;
                    b[y, x].Height = 50;
                    b[y, x].Left = (x * 50) + 10; //Offset 10 pixels from left
                    b[y, x].Top = (y * 50) + 20; //Offset 20 pixels from Top
                    b[y, x].Visible = true;
                    b[y, x].Click += Button_Click;
                    b[y, x].myGridX = x;
                    b[y, x].myGridY = y;
                    b[y, x].maxGridX = maxX;
                    b[y, x].maxGridY = maxY;
                    b[y, x].ToolTip(b[y, x].Name + " [" + y + "," + x + "]");
                    b[y, x].Padding = Padding.Empty;
                    b[y, x].Margin = Padding.Empty;
                    //b[y, x].ImageList = ButtonImageList;
                   
                    bgGame.Controls.Add(b[y, x]);

                }
            }
            return sharedTicTacToeBoardData;
        }

        private void btnGenerateGrid_Click(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            _stttbd = new SharedTicTacToeBoardData();
            _stttbd = GenerateGameButtons(_stttbd);
            
        }
        private void Button_Click(object sender, EventArgs e)
        {
            theButton = (sender as MMManagerTTTButton);
            theButton.explode();
            //Because the buttons are in a group box, and they have an odd border there is a visual annomoly from the falling buttons.
        }


        public void ExplosionCompletes(object sender, EventArgs e)
        {
            Sprite tSprite = (Sprite)sender;
            Point ePoint = tSprite.BaseImageLocation;
            tSprite.Destroy(); // Distroy Explosion.
            ShiftDown(ePoint,false); // Shift all down
        }

        private void ShiftDown(Point ePoint, bool waitForSpace)
        {
            int oldY = ePoint.Y;
            if (waitForSpace)
            {
                do
                {
                    //Stupid Single Thread
                    Application.DoEvents();
                    //Thread.Sleep(2);
                } while (pacMan.BaseImageLocation.X < (ePoint.X +10) );
            }
            while (oldY - 50 >= -50)
            {
                //Use OldY to locate sprites in old location
                foreach (var item in MySpriteController.SpritesAtImagePoint(new Point(ePoint.X+3, (oldY - 50)+3)))
                {
                    
                    //item.UnPause(SpritePauseType.PauseAll);
                    item.MovementSpeed = 8;
                    item.AutomaticallyMoves = true;
                    item.MoveTo(new Point(item.BaseImageLocation.X, item.BaseImageLocation.Y + 50));
                    Console.WriteLine(item.SpriteName + " Was moved to: " + (item.BaseImageLocation.Y + 50));
                }
                oldY = oldY - 50; // Move Up a Row
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Jack.PutBaseImageLocation(new Point(0, 0));
            //Jack.AnimateJustAFewTimes(0, 4);

            Coin.PutBaseImageLocation(new Point(0, 0));
           // return;
            //Generate Buttons as Sprites
            Sprite[,] sB = new Sprite[5, 5]; // Array of Sprites
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    sB[y,x] = MySpriteController.DuplicateSprite(SpriteNames.GreyButton.ToString());
                    sB[y, x].SetName("sB" + y + x);
                    sB[y, x].SpriteArrivedAtEndPoint += SpriteArrivedAtEndPoint;
                    sB[y, x].Click += SpriteButton_Click;
                    sB[y, x].PutBaseImageLocation((100), -50);
                    sB[y, x].SetSize(new Size(50, 50));
                    sB[y, x].MovementSpeed = 15;
                    sB[y, x].AutomaticallyMoves = true;
                    sB[y, x].Zvalue = 1;
                   // sB[y, x].ChangeAnimation(1, 9);
                    sB[y, x].MoveTo(new Point((int)(x*50), (int)(y*50)));
                    //sB[y, x].Pause(SpritePauseType.PauseAnimation);

                }
            }


            //Sprite nSprite = MySpriteController.DuplicateSprite(SpriteNames.GreyButton.ToString());
            //nSprite.SpriteArrivedAtEndPoint += SpriteArrivedAtEndPoint;
            ////nSprite.PutBaseImageLocation(0, -50);
            //nSprite.PutBaseImageLocation(-50, -50);
            //nSprite.SetSize(new Size(50, 50));
            //nSprite.MovementSpeed = 20;
            //nSprite.AutomaticallyMoves = true;
            //nSprite.MoveTo(new Point(0, 0));
          

        }

        private void SpriteButton_Click(object sender, SpriteEventArgs e)
        {
            
            Sprite me = (sender as Sprite);
            if (MySpriteController.SpritesAtImagePoint(new Point(me.BaseImageLocation.X + 20, me.BaseImageLocation.Y + 20)).Count <2)
            {
                Random r = new Random(DateTime.Now.Millisecond);
                if (r.Next(0, 6)>0)
                {
                    //Code to Do Explosion and shift Everyone Down
                    Sprite Exp; // Explosion Sprite
                    Exp = MySpriteController.DuplicateSprite(SpriteNames.explosion.ToString());
                    Exp.PutBaseImageLocation(me.BaseImageLocation.X, me.BaseImageLocation.Y);
                    Exp.SetSize(new Size(50, 50));
                    me.PutBaseImageLocation(me.BaseImageLocation.X, -50);
                    Exp.AnimateOnce(0);
                }
                else
                {
                    //Code to add player on top of button.
                    Sprite p = MySpriteController.DuplicateSprite("player1");
                    p.SetSize(new Size(50, 50));
                    p.Zvalue = 55;
                    
                    p.PutPictureBoxLocation(me.BaseImageLocation);
                    //p.PutBaseImageLocation(me.BaseImageLocation.X, (sender as Sprite).BaseImageLocation.Y); // Could offset
                    //p.Pause(SpritePauseType.PauseAnimation); // Don't animate
                    //p.MoveTo(p.BaseImageLocation); // Show it
                }
                
            }
        }

        private void SpriteArrivedAtEndPoint(object sender, SpriteEventArgs e)
        {
            int x = e.NewLocation.X;
            int y = e.NewLocation.Y;
            //(sender as Sprite).Pause(SpritePauseType.PauseAll);
            if (y != 0 && y != 50 && y!= 100)
            {
                Console.WriteLine((sender as Sprite).SpriteName +  " Done Moving and stopped at: " + y);
                //MessageBox.Show("Done Moving and stopped at: " + y);
            }
            //throw new NotImplementedException();
        }
        private void PacManArrivedAtEndPoint(object sender, SpriteEventArgs e)
        {
            Sprite tSprite = (Sprite)sender;
            tSprite.Destroy();
            mp.Stop();
        }
        private void BBomb_Click(object sender, EventArgs e)
        {
            playSound(1);
            //BBomb.TurnToPicture();
            //BBomb.explode();
            //Pacman Runs from left to right
            //Sprite nSprite = MySpriteController.DuplicateSprite("pacMan");
            pacMan = new Sprite(MySpriteController, Properties.Resources.PacMan, 50, 50, 100);
            pacMan.SetSize(new Size(40, 40));
            pacMan.SetName("pacMan");
            pacMan.Zvalue = 55;
            pacMan.SpriteArrivedAtEndPoint += PacManArrivedAtEndPoint;
            //REmove Comment to have collision detection
  //          pacMan.SpriteHitsSprite += NSprite_SpriteHitsSprite;

            pacMan.PutBaseImageLocation(-100, 110); // Have to offset
            pacMan.SetSize(new Size(30, 30));
            pacMan.MovementSpeed = 10;
            pacMan.AutomaticallyMoves = true;
            pacMan.Zvalue = 60;
           
            pacMan.MoveTo(new Point(300, 110)); // Move Off Screen
        }

        private void NSprite_SpriteHitsSprite(object sender, SpriteEventArgs e)
        {
            Sprite tSprite = (Sprite)e.TargetSprite;
            if (tSprite.MovingToPoint)
            {
                return;
                //we are moving ignore
            }
            if (tSprite.SpriteOriginName == "player1")
            {
                tSprite.Destroy();
            }
            Point ePoint = tSprite.BaseImageLocation;
            e.TargetSprite.PutBaseImageLocation(e.TargetSprite.BaseImageLocation.X, -50);
//            Console.WriteLine(e.TargetSprite.SpriteName + " Was moved to -50");
//            Console.WriteLine("Called ShiftDown: " + ePoint.Y);

            //Everyone bumps into PacMan
            ShiftDown(ePoint, true);
        }

        private void mmManagerTTTButton1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
