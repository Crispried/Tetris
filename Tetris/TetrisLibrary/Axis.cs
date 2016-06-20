using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisLibrary
{
    public class Axis
    {
        private string name;
                
        public Axis(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public bool Equals(Axis obj)
        {
            if(obj == null)
            {
                return false;
            }
            return name == obj.name ? true : false;
        }
    }
}
