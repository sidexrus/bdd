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

        public int checkresult(List<int> result)
        {
            if ((result[0] == result[1]) && (result[0] == result[2]) && result[0] != 0) return 1;
            return 2;
        }
    }
}
