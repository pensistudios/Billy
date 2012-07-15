using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billy
{
    class Component
    {
        int id;
        public string type;

        public Component(int iId)
        {
            id = iId;
            type = this.GetType().ToString();
        }

        // Only to be called by some sort of actor manager
        public void Apply(Actor actor)
        {
        }
    }
}
