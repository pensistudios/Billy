using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Billy
{
     class StaticComponent : DrawableComponent
    {
        int x, y;
        Vector2 myPos;
        Texture2D texture;

        System.IO.FileStream stream;
        //Potential problem with GraphicsDevice initializing null for some reason
        SpriteBatch spriteBatch;
        GraphicsDevice gd;

        public StaticComponent() 
        {
            spriteBatch = new SpriteBatch(gd);

            stream = new System.IO.FileStream("C:\\Programming\\Billy\\Billy\\BillyContent\\test.png", System.IO.FileMode.Open);
            texture = Texture2D.FromStream(gd, stream);
        }
        

        void Apply(Actor a)
        {
            myPos = a.pos;
        }

        public void Draw(GameTime gt) 
        {

            spriteBatch.Begin();
            spriteBatch.Draw(texture, myPos, Color.White);
            spriteBatch.End();
            

        }

    }
}
