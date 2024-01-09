using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Flow_Simulation
{
    public partial class MainForm : Form
    {
        private List<Line> lines;
        public MainForm()
        {
            InitializeComponent();

            lines = new List<Line>();
            LoadLines();

            mainTimer.Enabled = true;
        }

        private void LoadLines()
        {
            lines.Add(new Line(100, 200));
            lines.Add(new Line(600, 500));
            foreach (Line line in lines)
            {
                this.Controls.Add(line.pb);
            }
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            foreach (Line line in lines)
            {
                var loc = line.points[line.i % line.points.Count];
                loc.X -= 8;
                loc.Y -= 8;
                line.pb.Location = loc;
                line.i++;
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            foreach(Line line in lines)
            {
                e.Graphics.DrawLines(new Pen(Color.Black, 1), line.points.ToArray());
            }
        }
    }
}
