using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;


namespace Billy
{
    class ActorID
    {
        static int nextID = 0;

        public static int getNewID()
        {
            int temp = nextID;
            nextID++;
            return temp;
        }
    }


    class Actor
    {
        // private Input
        int id;
        string type;
        public Microsoft.Xna.Framework.Vector2 pos;

        public Actor() 
        {
            id = ActorID.getNewID();
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

        public void addComponent(Component c)
        {
            components.Add(c);
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
