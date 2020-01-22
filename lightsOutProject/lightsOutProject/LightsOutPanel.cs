using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lightsOutProject
{
    class LightsOutPanel : Panel
    {
        public bool on_off;
        public int coordX, coordY; 

        public LightsOutPanel(int x, int y)
        {
            coordX = x;
            coordY = y;
            this.on_off = false;
        }

        public void changeColor()
        {
            if (on_off)
            {
                this.BackColor = Color.Goldenrod;
            }
            else
            {
                this.BackColor = Color.MidnightBlue;
            }
        }
        public void changeOn_Off()
        {
            if (this.on_off)
            {
                this.on_off = false;
            }
            else
            {
                this.on_off = true;
            }
            this.changeColor();
        }
    }
}
