using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FirstGraphsProgram
{
    class DrawC
    {
        private GraphC c;
        public DrawC(GraphC a)
        {
            c = a;
        }
        public int[] dist { get; set; }
        public List<NodeC> nodes
        {
            get
            {
                return c.nodes;
            }
        }
       
        const int radius = 11;

        public int FindNode(int aX, int aY) // передаёт номер узла на который нажимаю
        {
            int result = -1;
            for (int i = 0; i < nodes.Count; i++)
            {
                int nx = nodes[i].x;
                int ny = nodes[i].y;
                if ((nx - aX) * (nx - aX) + (ny - aY) * (ny - aY) < 2700)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
        //public int FindEdge(int aX,int aY)
        //{
        //    int result = -1;
        //    for (int i = 0; i < edge.Count; i++)
        //    {
        //        //int nx = nodes[i].edge[i].Neighbour.x;
        //        //int ny = nodes[i].edge[i].Neighbour.y;

        //        if () 
        //        {
        //            result = i;
        //            break;
        //        }

        //    }
        //    return result;
        //}
        public void GetNode(List<NodeC> node, ref int n1, ref int n2) //выбирает узлы начало и конец пути
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].Choosen)
                {
                    if (n1 == -1)
                        n1 = i;
                    else n2 = i;
                }
            }
        }

        public void ShowGraph(Graphics gr, Color col)
        {
            Font font = new Font("Arial", 10, FontStyle.Regular);
            int NumNodes = nodes.Count;
            for (int i = 0; i < NumNodes; i++)
            {
                int numE = nodes[i].edge.Count;
                int curX = nodes[i].x;
                int curY = nodes[i].y;

                for (int j = 0; j < numE; j++) // рисуем рёбра
                {
                    int toX = nodes[i].edge[j].Neighbour.x;
                    int toY = nodes[i].edge[j].Neighbour.y;
                    Color cl = nodes[i].edge[j].color;
                    Pen pen = new Pen(cl, 3);
                    gr.DrawLine(pen, curX + 21, curY + 11, toX + 21, toY + 11);
                    string dist = Convert.ToString(nodes[i].edge[j].lehgth);
                    int captionX = (curX + toX) / 2;
                    int captionY = (curY + toY) / 2;
                    Rectangle rec = new Rectangle(captionX, captionY, 50, 21);
                    gr.DrawString(dist, font, Brushes.Black, rec);
                }
            }//  рёбра всех узлов

            for (int i = 0; i < NumNodes; i++)
                DrawNode(gr, nodes[i]); // рисуем узлы
        }

        public void DrawNode(Graphics graphics, NodeC node)
        {
            Pen pen = new Pen(Color.Black, 3);
            Font font = new Font("Arial", 10, FontStyle.Regular);
            SolidBrush sb = new SolidBrush(node.color);
            SolidBrush sbstring = new SolidBrush(Color.Black);

            graphics.DrawEllipse(pen, node.x - radius, node.y - radius, 3 * radius, 3 * radius);
            graphics.FillEllipse(sb, node.x - radius, node.y - radius, 3 * radius, 3 * radius);
            graphics.DrawString(node.name + ":" + c.GetIndexByName(node.name) + ":" + node.NumberOfEnemies() + ":" + node.NumberOfFriends() + ":" + node.GroupNumber, font, sbstring, node.x, node.y);
            graphics.DrawString(node.names, font, Brushes.Black, node.x - 20, node.y - 27);

            //graphics.DrawString(c.GetIndexByName(node.name) + ":" + node.Count.ToString(), font, sbstring, node.x, node.y);
        }
    }
}