using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FirstGraphsProgram
{
    public class NodeC
    {
        public class Edge
        {
            public int A { get; set; }
            public NodeC Neighbour { get; set; }
            public Color color { get; set; }
            public int lehgth { get; set; }

            private int r = 0;
            public int relation
            {
                get { return r; }

                set { r = value; ColorEdge(); }
            }

            public void ColorEdge()
            {
                if (r == 1)
                {
                    color = Color.Green;
                }
                else if (r == 2)
                {
                    color = Color.Red;
                }
                else if (r == 3)
                {
                    color = Color.PeachPuff;
                }
            }
        }

        public string name { get; set; }
        public List<Edge> edge;
        public int numVisit { get; set; }
        public bool visit { get; set; }
        public string names { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Color color = Color.DeepPink;
        public bool Choosen { get; set; }

        public int Count = 0;
        public int GroupNumber;

        public NodeC(int ex, int ey, string number)
        {
            name = number.ToString();
            x = ex; y = ey;
            edge = new List<Edge>();
        }

        public int NumberOfEnemies()
        {
            int count = 0;
            for (int i = 0; i < edge.Count; i++)
            {
                if (edge[i].relation == 2)
                    count++;
            }
            return count;
        }

        public int NumberOfFriends()
        {
            int count = 0;
            for (int i = 0; i < edge.Count; i++)
            {
                if (edge[i].relation == 1)
                    count++;
            }
            return count;
        }
    }
}
