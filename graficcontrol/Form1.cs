using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace graficcontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            controlgrafica1.g.DrawEllipse(controlgrafica1.pen0, 100, 100, 620, 210);
            controlgrafica1.g.DrawEllipse(controlgrafica1.pen0, 100, 100, 122, 220);
            controlgrafica1.g.DrawEllipse(controlgrafica1.pen0, 100, 100, 524, 230);
            controlgrafica1.g.DrawEllipse(controlgrafica1.pen0, 100, 100, 225, 240);
            controlgrafica1.g.DrawEllipse(controlgrafica1.pen0, 100, 100, 427, 250);
            controlgrafica1.g.DrawEllipse(controlgrafica1.pen0, 100, 100, 328, 260);

            controlgrafica2.g.DrawEllipse(controlgrafica1.pen0, 100, 100, 620, 210);
            controlgrafica2.g.DrawEllipse(controlgrafica1.pen0, 100, 100, 122, 220);
            controlgrafica2.g.DrawEllipse(controlgrafica1.pen0, 100, 100, 524, 230);
            controlgrafica2.g.DrawEllipse(controlgrafica1.pen0, 100, 100, 225, 240);
            controlgrafica2.g.DrawEllipse(controlgrafica1.pen0, 100, 100, 427, 250);
            controlgrafica2.g.DrawEllipse(controlgrafica1.pen0, 100, 100, 328, 260);

        }
    }
}
