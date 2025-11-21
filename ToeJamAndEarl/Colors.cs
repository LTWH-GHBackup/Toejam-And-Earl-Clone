using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeJamAndEarlFirstBatch
{
    public struct TJEColor
    {
        int r, g, b;

        public TJEColor(int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    };

    public class TJEColors
    {
        public static TJEColor landbackground = new TJEColor(0, 130, 0);
    }
}
