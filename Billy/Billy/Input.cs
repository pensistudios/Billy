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
        public Boolean goLeft, goRight, jump, drop;

        public void Update(GameTime gt) { }

    }

    class InputEvent : Event
    {
        public Input input;
    }
}
