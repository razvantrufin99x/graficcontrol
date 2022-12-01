using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace graficcontrol
{
    public partial class controlgrafica : UserControl
    {
        public controlgrafica()
        {
            InitializeComponent();
        }
        public Graphics g;
        public Pen pen0 = new Pen(Color.Black,1);
        public Brush brush0 = new SolidBrush(Color.Black);
        public Font font0 = new Font("Arial", 10);


        private void controlgrafica_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();

        }
    }
}
