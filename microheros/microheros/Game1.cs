using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace microheros
{
    
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D back;
        Rectangle rec;

        List<SuperHero> Heros = new List<SuperHero>();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);

            graphics.PreferredBackBufferWidth = 1707;
            graphics.PreferredBackBufferHeight = 1067;

            Content.RootDirectory = "Content";


        }

        
        protected override void Initialize()
        {
            SuperHero.Con = Content;
            Heros.Add(new SuperHero());
            Heros.Add(new FlyHero("superMan"));
            Heros.Add(new ShrinkHero("antMan"));
            Heros.Add(new MorphHero("hulk"));
            Heros.Add(new SuperHero("batMan"));
            Heros.Add(new FlyHero("ironMan"));
            Heros.Add(new ShrinkHero("atom"));


            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            back = Content.Load<Texture2D>("Universe");
            rec = new Rectangle(0, 0, 1707, 1067);
        }
        
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            spriteBatch.Begin();

            spriteBatch.Draw(back, rec, Color.White);
            
            for(int i = Heros.Count - 1; i >= 0; i--)
            {
                Heros[i].Draw(spriteBatch);
            }
            

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
