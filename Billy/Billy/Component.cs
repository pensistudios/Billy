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
    }
}
