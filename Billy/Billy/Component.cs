using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billy
{
    class ComponentID
    {
        static int nextID = 0;

        public static int getNewID()
        {
            int temp = nextID;
            nextID++;
            return temp;
        }
    }

    class Component
    {
        int id;
        public string type;
        public List<string> listeners; 

        public Component()
        {
            id = ComponentID.getNewID();
            type = this.GetType().ToString();
            listeners = new List<string>();
        }

        // Only to be called by some sort of actor manager
        public void Apply(Actor actor)
        {
        }
    }
}
