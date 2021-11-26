using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class
{
    public class ImplementClassHello : Hello
    {
        public int Map;

        public String Name
        {
            get => default;
            set
            {
            }
        }

        public int x
        {
            get => default;
            set
            {
            }
        }

        public int y
        {
            get => default;
            set
            {
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void jumpToLocation(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}