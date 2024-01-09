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
                foreach(var pb in line.pbs)
                {
                    this.Controls.Add(pb);
                }
            }
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            foreach (Line line in lines)
            {
                for(int i = 0; i < 3; i++)
                {
                    if(i == 0)
                    {
                        var loc = line.points[line.i % line.points.Count];
                        loc.X -= 8;
                        loc.Y -= 8;
                        line.pbs[i].Location = loc;
                        line.i++;
                    }
                    else if(i == 1)
                    {
                        var loc = line.points[line.j % line.points.Count];
                        loc.X -= 8;
                        loc.Y -= 8;
                        line.pbs[i].Location = loc;
                        line.j += 2;
                    }
                    else
                    {
                        var loc = line.points[line.k % line.points.Count];
                        loc.X -= 8;
                        loc.Y -= 8;
                        line.pbs[i].Location = loc;
                        line.k += 3;
                    }
                }
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
