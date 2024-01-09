using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Flow_Simulation
{
    public class Line
    {
        public List<Point> points;
        public int i;
        public PictureBox pb;
        public Line(int x, int y)
        {
            var line = new GenerateLine(x, y);
            this.points = new List<Point>(line.GetPoints);
            i = 0;

            pb = new PictureBox();
            pb.BackColor = Color.Transparent;
            pb.Image = Properties.Resources.WaterDrop;
            pb.Location = new Point(x, y); 
            pb.Size = new Size(16, 16);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
