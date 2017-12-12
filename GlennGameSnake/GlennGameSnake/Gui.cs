using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GlennGameSnake
{
    class Gui
    {
        public TableLayoutPanel MainTable { get; set;}
        public TableLayoutPanel MenuTable { get; set; }
        public StatusStrip StatusStrip1 { get; set; }
        public Label SpaceBarLabel { get; set; }
        public ToolStripStatusLabel SnakeScoreLabel1 { get; set; }
        public ToolStripStatusLabel SnakeScoreLabel2 { get; set; }
        public ToolStripStatusLabel ToolStripStatusLabel1 { get; set; }

        public Gui()
        {
            //MainTable.
            MainTable = new TableLayoutPanel
            {
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                BackColor = Color.BlanchedAlmond
            };

            //Info to user.
            SpaceBarLabel = new Label
            {
                Text = "Tryck space för att börja!",
                AutoSize = true,
                TabIndex = 1
            };
            MainTable.Controls.Add(SpaceBarLabel);

            //MenuTable.
            MenuTable = new TableLayoutPanel
            {
                Height = 30,
                Width = 400,
                ColumnCount = 4,
                Dock = DockStyle.Bottom,
                BackColor = Color.White
            };
            MainTable.Controls.Add(MenuTable);

            //StatusStrip that will hold 3 labels.
            StatusStrip1 = new StatusStrip
            {
                TabIndex = 0,
                Name = "statusStrip1",
            };
            MenuTable.Controls.Add(StatusStrip1);

            SnakeScoreLabel1 = new ToolStripStatusLabel
            {
                Text = "Score: "
            };

            SnakeScoreLabel2 = new ToolStripStatusLabel
            {
                Text = "0"
            };

            ToolStripStatusLabel1 = new ToolStripStatusLabel
            {
                
            };
            //Adding my labels into the StatusStrip.
            StatusStrip1.Items.AddRange(new ToolStripItem[] { SnakeScoreLabel1, SnakeScoreLabel2, ToolStripStatusLabel1 });
        }
    }
}
