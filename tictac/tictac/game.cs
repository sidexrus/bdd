using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictac
{
    public class game
    {
        public int uu;
        public bool x_o = true;

        public void next_step()
        {
            x_o = !x_o;
        }
    }
}
