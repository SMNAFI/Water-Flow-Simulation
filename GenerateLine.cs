using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Water_Flow_Simulation;

namespace Water_Flow_Simulation
{
    public class GenerateLine
    {
        private Point p;
        private List<Point> points;
        public GenerateLine(int x, int y)
        {
            p = new Point(x, y);
            points = new List<Point>();
            GeneratePoints();
        }
        public List<Point>  GetPoints => points;

        private void GeneratePoints()
        {
            for (int i = 0; i < 10; i++)
            {
                points.Add(new Point(p.X, p.Y));
                p.X += 10;
            }
            for (int i = 0; i < 10; i++)
            {
                points.Add(new Point(p.X, p.Y));
                p.Y += 10;
            }
            for (int i = 0; i < 10; i++)
            {
                points.Add(new Point(p.X, p.Y));
                p.X += 10;
                p.Y += 10;
            }
            for (int i = 0; i < 10; i++)
            {
                points.Add(new Point(p.X, p.Y));
                p.X += 10;
                p.Y -= 10;
            }
        }
    }
}
