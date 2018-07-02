using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FirstGraphsProgram
{
    public partial class Graphs : Form
    {
        public Graphs()
        {
            InitializeComponent();
            da = new DrawC(graph);
        }
        DrawC da;
        GraphC graph = new GraphC();
        private void Graphs_MouseDown(object sender, MouseEventArgs e) //работа с узлами
        {
            if (AddANewNodeRBtn.Checked)//добавляет узлы
            {
                GiveNames fen = new GiveNames();
                fen.Name = "No name";
                Graphics gr = CreateGraphics();
                //graph.AddNode(e.X, e.Y);
                int len = graph.nodes.Count;
                if (fen.ShowDialog() == DialogResult.OK)
                {
                    graph.AddNode(e.X, e.Y);
                    len = graph.nodes.Count;
                    graph.nodes[graph.nodes.Count - 1].names = fen.Name;

                }
                da.DrawNode(gr, graph.nodes[len - 1]);
                gr.Dispose();
            }
            else if (AddAnEdgeRBtn.Checked)//рисует ребра
            {
                int n = da.FindNode(e.X, e.Y);
                if (n != -1)
                {
                    graph.DrawEdge = true;
                    graph.nodeIn = n;
                }
            }
            else if (ChooseTwoNodesRBtn.Checked)//окрашивает два ущла начало и конец пути
            {
                int n = da.FindNode(e.X, e.Y);
                if (n != -1)
                {
                    Graphics gr = CreateGraphics();
                    graph.ChooseTrue(n);
                    da.DrawNode(gr, graph.nodes[n]);
                }
            }
            
            else if(ChooseFriendRBtn.Checked)
            {
                graph.ToggleRelation(e.X, e.Y);
                //int n = da.FindNode(e.X, e.Y);
                Graphics gr = CreateGraphics();
                gr.Clear(DefaultBackColor);
                da.ShowGraph(gr, DefaultBackColor);
            }

            else if (ClearTwoNodesRBtn.Checked)//очищает узлы и возвращает прежний цвет
            {
                int n = da.FindNode(e.X, e.Y);
                if (n != -1)
                {
                    Graphics gr = CreateGraphics();
                    graph.ChooseFalse(n);
                    da.DrawNode(gr, graph.nodes[n]);
                }
            }
        }

        private void Graphs_MouseMove(object sender, MouseEventArgs e) //проводит линию
        {
            if (graph.DrawEdge)
            {
                Graphics gr = CreateGraphics();
                Pen pen = new Pen(Color.PeachPuff, 1);
                gr.DrawEllipse(pen, e.X, e.Y, 1, 1);
                gr.Dispose();
                pen.Dispose();
            }
        }

        private void Graphs_MouseUp(object sender, MouseEventArgs e)//линия ребра
        {
            if (AddAnEdgeRBtn.Checked)
            {
                int n = da.FindNode(e.X, e.Y);
                if (n != -1) graph.AddEdge(graph.nodeIn, n);
                Graphics gr = CreateGraphics();
                gr.Clear(DefaultBackColor);
                da.ShowGraph(gr, DefaultBackColor);
                gr.Dispose();
                graph.DrawEdge = false;
            }
        }

        private void FindANodeBtn_Click(object sender, EventArgs e)//результирующая кнопка
        {
            Graphics gr = CreateGraphics();
            graph.ClearVisit();
            int n1 = -1, n2 = -1;
            da.GetNode(graph.nodes, ref n1, ref n2);
            graph.FindNodeNew(n1, n2);
            da.ShowGraph(gr, DefaultBackColor);
            GetN1TB.Text = n1.ToString();
            GetN2TB.Text = n2.ToString();
        }


        private void ClearBtn_Click_1(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            Rectangle rec = new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height);
            Color col = DefaultBackColor;
            gr.Clear(col);
            gr.Dispose();
            graph.Clear();
            graph.DrawEdge = false;
        }

        private void DeleteEdgeBtn_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            int n1 = graph.GetIndexByName(GetN1TB.Text);
            int n2 = graph.GetIndexByName(GetN2TB.Text);
            graph.DeleteEdge(n1, n2);
            gr.Clear(DefaultBackColor);
            da.ShowGraph(gr, DefaultBackColor);
        }

        private void SaveFileBtn_Click(object sender, EventArgs e)
        {
            SFD.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                string safname = SFD.FileName;
                graph.SaveGraph(safname);
            }
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            OFD.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                string openname = OFD.FileName;
                graph.ReadGraph(openname);
                da.ShowGraph(gr, DefaultBackColor);
            }
        }

        private void DeleteNodeBtn_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            int n = graph.GetIndexByName(GetN1TB.Text);
            graph.DeleteNode(n);
            gr.Clear(DefaultBackColor);
            da.ShowGraph(gr, DefaultBackColor);
        }

        private void GamiltonBtn_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            int n = graph.GetIndexByName(GetN1TB.Text);
            graph.GamiltonPath(n);
            gr.Clear(DefaultBackColor);
            da.ShowGraph(gr, DefaultBackColor);
        }

        private void FindAGroupBtn_Click(object sender, EventArgs e)
        {
            graph.Group(Convert.ToInt32(GetN1TB.Text));
            Graphics gr = CreateGraphics();
            gr.Clear(DefaultBackColor);
            da.ShowGraph(gr, DefaultBackColor);
        }
    }
}
