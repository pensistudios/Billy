using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Billy
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Billy : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        PlayerInput keyboard;
        StaticComponent statictestComp;

        

        List<Actor> actors;

        public Billy()
        {
            actors = new List<Actor>();
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            base.Initialize();

            keyboard = new PlayerInput();

            //Init player
            Actor player = new Actor();
            MoveableComponent pic = new MoveableComponent();
            player.addComponent(pic);
            statictestComp = new StaticComponent(GraphicsDevice);
            player.addComponent(statictestComp);
            //player.addComponent(statictestComp);
                
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
   
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            keyboard.Update(gameTime);

            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            foreach (Actor a in actors)
            {
                if (a.hasComponent("MoveableComponent"))
                {
                    MoveableComponent c = (MoveableComponent)a.getComponent("MoveableComponent");
                    c.Update(keyboard);
                    c.Apply(a);

                    StaticComponent dc = (StaticComponent)a.getComponent("StaticComponent");
                    dc.Apply(a);
                }
            }


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


            foreach (Actor a in actors)
            {
                if (a.hasComponent("DrawableComponent"))
                {
                    StaticComponent c = (StaticComponent)a.getComponent("StaticComponent");
                    c.Draw(gameTime);
                    
                    //c.Apply(a);
                    //c.Draw(gameTime); 
                }

            }
            statictestComp.Draw(gameTime);

            base.Draw(gameTime);
        }
    }
}
