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

        PlayerInput testInput;
        StaticComponent statictestComp;
        

        public Billy()
        {
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
<<<<<<< HEAD
            keyboard = new PlayerInput();

            //Init player
            Actor player = new Actor();
            PlayerInputComponent pic = new PlayerInputComponent();
            player.addComponent(pic);
=======
            testInput = new PlayerInput();
            statictestComp = new StaticComponent();
>>>>>>> 9e250e4bf89b5260edf5d94e5cf6a9c7d9bbc600
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
                if (a.hasComponent("PlayerInputComponent"))
                {
                    PlayerInputComponent c = (PlayerInputComponent)a.getComponent("PlayerInputComponent");
                    c.Update(keyboard);
                    c.Apply(a);
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

<<<<<<< HEAD
            foreach (Actor a in actors)
            {
                if (a.hasComponent("DrawableComponent"))
                {
                    DrawableComponent c = (DrawableComponent)a.getComponent("DrawableComponent");
                    
                    c.Apply(a);
                    c.Draw(gameTime); 
                }

            }

=======
            statictestComp.Draw(gameTime);
>>>>>>> 9e250e4bf89b5260edf5d94e5cf6a9c7d9bbc600
            base.Draw(gameTime);
        }
    }
}
