using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;
using AnimatedSprite;

namespace AnimatedSpriteWindows
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private AnimatedTexture SpriteTexture;
        private const float Rotation = 0;
        private const float Scale = 2.0f;
        private const float Depth = 0.5f;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            SpriteTexture = new AnimatedTexture(Vector2.Zero,
                Rotation, Scale, Depth);
#if ZUNE
            // Frame rate is 30 fps by default for Zune.
            TargetElapsedTime = TimeSpan.FromSeconds(1 / 30.0);
#endif
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        private Viewport viewport;
        private Vector2 shipPos;
        private const int Frames = 4;
        private const int FramesPerSec = 2;
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // "shipanimated" is the name of the sprite asset in the project.
            SpriteTexture.Load(Content, "shipanimated", Frames, FramesPerSec);
            viewport = graphics.GraphicsDevice.Viewport;
            shipPos = new Vector2(viewport.Width / 2, viewport.Height / 2);
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

#if WINDOWS
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();
#endif

            // Pauses and plays the animation.
            if (GamePad.GetState(PlayerIndex.One).Buttons.A ==
                ButtonState.Pressed)
            {
                if (SpriteTexture.IsPaused)
                    SpriteTexture.Play();
                else
                    SpriteTexture.Pause();
            }
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;

            // TODO: Add your game logic here.
            SpriteTexture.UpdateFrame(elapsed);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            SpriteTexture.DrawFrame(spriteBatch, shipPos);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
