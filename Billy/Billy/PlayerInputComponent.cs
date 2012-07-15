using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billy
{
    class PlayerInputComponent : Component
    {
        public int moveSpeed = 25;
        PlayerInput copy;

        public void Update(PlayerInput input)
        {
            copy = input;
        }
   

        public void Apply(Actor a)
        {
            if (copy.goLeft)
                a.pos.X -= moveSpeed;
            if (copy.goRight)
                a.pos.X += moveSpeed;
        }
    }
}

