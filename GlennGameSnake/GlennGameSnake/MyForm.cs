using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GlennGameSnake
{
    class MyForm : Form
    {
        Gui gui = new Gui();
        public MyForm()
        {
            Height = 400;
            Width = 400;

            Controls.Add(gui.MainTable);
        }
    }
}
