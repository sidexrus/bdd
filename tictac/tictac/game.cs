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
            if ((result[0] == result[3]) && (result[0] == result[6]) && result[0] != 0) return 1;
            if ((result[1] == result[4]) && (result[1] == result[7]) && result[1] != 0) return 1;
            if ((result[2] == result[5]) && (result[2] == result[8]) && result[2] != 0) return 1;
            return 2;
        }
    }
}
