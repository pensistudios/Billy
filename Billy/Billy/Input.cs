using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;



namespace Billy
{
    class Input 
    {
        KeyboardState keyboard;
        Boolean goLeft, goRight, jump, drop;



        public void Update() 
        {
            // keyboard initialization
            keyboard  = Keyboard.GetState();

            //Debug writes to Debug Console

            //Debug.Write(goLeft);
            //Debug.Write(goRight);
            //Debug.Write(jump);
            //Debug.Write(drop);


            //Keyboard update code works by checking 
            //for keys pressed and sets boolean respectively
            // keyboard uses KeyboardState from XNA 4.0 to gather input
            if (keyboard.IsKeyDown(Keys.Left) == true)
                goLeft = true;
            else
                goLeft = false;
            if (keyboard.IsKeyDown(Keys.Right) == true)
                goRight = true;
            else
                goRight = false;
            if (keyboard.IsKeyDown(Keys.Up) == true)
                jump = true;
            else
                jump = false;
            if (keyboard.IsKeyDown(Keys.Down) == true)
                drop = true;
            else
                drop = false;
            
        }


    }
}
