using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billy
{
    class MoveableComponent : Component
    {
        public int moveSpeed = 25;
        Input copy;

        public MoveableComponent()
            : base()
        {
            listeners.Add("InputEvent");
        }
        

        public void Update(PlayerInput input)
        {
        }
        
        public void on(InputEvent e)
        {
            copy = e.input; 
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

