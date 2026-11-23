using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Monogame_1___Adding_content
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;

        Texture2D dinoTexture;
        Texture2D cheeseTexture;
        Texture2D MarioTexture;
        Texture2D backgroundTexture;
        
        Vector2 cheesePosition;
        Random random = new Random();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            window = new Rectangle(0, 0, 800, 500);
            this.Window.Title = "Mr. Aldworth";

            // Resize window
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            cheesePosition = new Vector2(random.Next(0, 700), random.Next(0, 400));

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here]
            dinoTexture = Content.Load<Texture2D>("dino");

            cheeseTexture = Content.Load<Texture2D>("cheese");

            MarioTexture = Content.Load<Texture2D>("Mario");

            backgroundTexture = Content.Load<Texture2D>("background");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Gray);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(backgroundTexture, new Rectangle(0, 0, 800, 500), Color.White);

            _spriteBatch.Draw(dinoTexture, new Vector2(40, 5), Color.White);

            _spriteBatch.Draw(cheeseTexture, cheesePosition, Color.White);

            _spriteBatch.Draw(MarioTexture, new Vector2(240, 5), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
