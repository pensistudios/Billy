using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;


namespace Billy
{
    class Actor
    {
        // private Input
        int id;
        string type;

        public Actor(int iId) 
        {
            id = iId;
            type = this.GetType().ToString();
        }

        void Update(GameTime gt) {}
       
        List<Component> components;

        public bool hasComponent(String type) 
        {
            if (!type.StartsWith("Billy."))
            {
                type = "Billy." + type;
            }

            foreach (Component c in components)
            {
                if (c.type == type)
                    return true;
            }
            return false;
        }

        public Component getComponent(String type)
        {
            foreach (Component c in components)
            {
                if (c.type == type)
                    return c;
            }

            return new Component();
        }

        
    }
}
