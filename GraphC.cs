using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace FirstGraphsProgram
{
    class GraphC
    {
        public int nodeIn { get; set; }
        public bool DrawEdge = false;

        public List<NodeC> nodes;
        public int[,] A { get; set; }
        public int[] dist { get; set; }
        public int Num { get; set; }
        public List<int> PathGamilt;
        public List<int> PathGamilt1;
        public List<GroupC> groups;
        private List<NodeC> cs;
        //bool WayFound = false;

        public GraphC()
        {
            nodes = new List<NodeC>();
            PathGamilt = new List<int>();
            PathGamilt1 = new List<int>();
            groups = new List<GroupC>();
        }

        public void AddNode(int x, int y)
        {
            string len = "0";
            for (int i = 1; i < nodes.Count + 2; i++)
            {
                len = i.ToString();
                if (GetIndexByName(len)== -1)
                {
                    break;
                }
            }
            nodes.Add(new NodeC(x, y, len));
        }

        bool TestEdge(int n1, int n2)
        {
            int len = nodes[n1].edge.Count;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < nodes[n2].edge.Count; j++)
                {
                    if (nodes[n1].edge[i].Neighbour == nodes[n2] && nodes[n2].edge[j].Neighbour == nodes[n1])
                        return true;
                }
            }
            return false;
        }

        int TestEdgeIndex(int n1, int n2)
        {
            int len = nodes[n1].edge.Count;
            for (int i = 0; i < len; i++)
            {
                if (nodes[n1].edge[i].Neighbour == nodes[n2])//.NumNode == n2 || n1 == n2)
                    return i;
            }
            return -1;
        }
        public void AddEdge(int n1, int n2)
        {
            if (!TestEdge(n1, n2))
            {
                int dx = nodes[n2].x - nodes[n1].x;
                int dy = nodes[n2].y - nodes[n1].y;
                double x = dx * dx + dy * dy;
                x = Math.Pow(x, 0.5);
                int dist = Convert.ToInt32(x);  // длина ребра -- расстояние между узлами n1 и n2
                int len = nodes[n1].edge.Count;
                NodeC.Edge edge = new NodeC.Edge();
                edge.lehgth = dist;
                edge.Neighbour = nodes[n2];
                edge.color = Color.PeachPuff;
                nodes[n1].edge.Add(edge);

                len = nodes[n2].edge.Count;
                edge = new NodeC.Edge();
                edge.lehgth = dist;
                edge.Neighbour = nodes[n1];
                edge.color = Color.PeachPuff;
                nodes[n2].edge.Add(edge);
            }
        }

        public int GetNodeIndex(NodeC node)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i] == node)
                    return i;
            }
            return -1;
        }

        public void DeleteNode(int n)
        {
            int L = nodes[n].edge.Count;
            for (int i = 1; i < L + 1; i++)
            {
                DeleteEdge(n, GetNodeIndex(nodes[n].edge[0].Neighbour));
            }
            nodes.Remove(nodes[n]);
        }

        public void DeleteEdge(int n1, int n2)
        {
            if (TestEdge(n1, n2))
            {
                int L = nodes[n1].edge.Count;
                int L1 = nodes[n2].edge.Count;

                for (int i = 0; i < L; i++)
                {
                    if (nodes[n1].edge[i].Neighbour == nodes[n2])
                    {
                        nodes[n1].edge.RemoveAt(i);
                        break;
                    }
                }
                for (int i = 0; i < L1; i++)
                {
                    if (nodes[n2].edge[i].Neighbour == nodes[n1])
                    {
                        nodes[n2].edge.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        public void VisitTrue(int n)//метод отметки посещенных вершин. На вход подается сам узел.
        {
            Num++;//увеличивается количество посещённых вершин
            nodes[n].visit = true; //n-ой вершине ставится метка посещённости
            nodes[n].numVisit = Num;
        }

        public void VisitFalse(int n)//метод отметки посещенных вершин. На вход подается сам узел.
        {
            Num--;//увеличивается количество посещённых вершин
            nodes[n].visit = false; //n-ой вершине ставится метка посещённости
            nodes[n].numVisit = Num;
        }
 
        public int[,] CreateMatrix() //создание  матрицы смежности
        {
            int n = nodes.Count;
            A = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                A[i, i] = 0;
                int eL = 0;
                if (nodes[i].edge != null)
                {
                    eL = nodes[i].edge.Count;
                    for (int j = 0; j < eL; j++)
                    {
                        A[i, GetNodeIndex(nodes[i].edge[j].Neighbour)] = nodes[i].edge[j].relation;
                    }
                }
            }
            return A;
        }

        public int CreateEdge(int[,] a) //создание  матрицы смежности
        {
            int n = 0 ;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    int dx = nodes[j].x - nodes[i].x;
                    int dy = nodes[j].y - nodes[i].y;
                    double x = dx * dx + dy * dy;
                    x = Math.Pow(x, 0.5);
                    int dist = Convert.ToInt32(x);
                    if (a[i, j] != 0)
                    {
                        NodeC.Edge edge = new NodeC.Edge();
                        edge.lehgth = dist;
                        edge.Neighbour = nodes[j];
                        edge.relation = a[i, j];
                        edge.ColorEdge();
                        nodes[i].edge.Add(edge);
                    }
                }
            }
            return n;
        }

        private void FindNode(int n, int n2)
        {
            VisitTrue(n);
            if (n == n2)
            {
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (nodes[i].visit)
                    {
                        nodes[i].Count++;
                    }
                }
                VisitFalse(n);
                return;
            }
            
            for (int i = 0; i < nodes[n].edge.Count; i++)
            {
                int m = GetNodeIndex(nodes[n].edge[i].Neighbour);
                if (!nodes[m].visit)
                {
                    FindNode(m, n2);
                }
            }
            VisitFalse(n);
        }

        private bool CheckTrueAll() //посещены ли все точки 
        {
            int c = 0;
            for(int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].visit) c++;
            }
            if (c == nodes.Count) return true;
            return false;
        }
        private void Gamilton(int n, int now)
        {
            VisitTrue(now);
            //PathGamilt.Add(now);
            for (int i = 0; i < nodes[now].edge.Count; i++)
            {
                if (nodes[now].edge[i].relation != 1)//если не друг
                    continue;
                int m = GetNodeIndex(nodes[now].edge[i].Neighbour);//индекс текущего ребра
                PathGamilt.Add(m); //добавляем в первый путь
                if (m == n && CheckTrueAll())// если следующая последняя и все отмечены
                {
                    //PathGamilt.Add(now);
                    for(int j = 0; j < PathGamilt.Count; j++) //добавляем все в список
                    {
                        PathGamilt1.Add(PathGamilt[j]);
                    }
                    return;
                }
                if (!nodes[m].visit)
                {
                    //PathGamilt.Add(now);
                    Gamilton(n, m);
                }
                if (PathGamilt1.Count == 0)// если путь не найден то мы удаляем номер последнего посещенного узла
                PathGamilt.RemoveAt(PathGamilt.Count - 1);
            }
            VisitFalse(now);//обнуляем первую вершину
        }

        public int GetIndexInAllNodes(NodeC f)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i] == f)
                    return i; 
            }
            return -1;
        }

        public void GamiltonPath(int n)
        {
            Gamilton(n, n);
            for (int i = 0; i < PathGamilt1.Count; i++)
            {
                int j = (i + 1) % PathGamilt1.Count;
                int I = PathGamilt1[i];
                int J = PathGamilt1[j];
                int q = TestEdgeIndex(I, J);
                int c = TestEdgeIndex(J, I);
                if (q >= 0)
                    nodes[I].edge[q].color = Color.Blue;
                if (c >= 0)
                    nodes[J].edge[c].color = Color.Blue;
                        
                
            }
        }

        public void FindNodeNew(int n1, int n2)
        {
            ClearVisit();
            int count = 0;
            FindNode(n1, n2);
            count = nodes[n1].Count;
            for (int i = 1; i < nodes.Count; i++)
            {
                if (nodes[i].Count == count && !nodes[i].Choosen)
                {
                    nodes[i].color = Color.BlanchedAlmond;
                }
            }
        }

        public void Clear()
        {
            nodes.Clear();
        }

        public void ClearVisit() //метод снятия посещенности
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                nodes[i].visit = false;
                nodes[i].Count = 0;
            }
        }
        public int GetIndexByName(string name)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (name == nodes[i].name)
                    return i;
            }
            return -1;
        }

        public void ChooseTrue(int n)
        {
            nodes[n].Choosen = true;
            nodes[n].color = Color.Aquamarine;
        }
        public void ChooseFalse(int n)
        {
            nodes[n].Choosen = false;
            nodes[n].color = Color.DeepPink;
        }
        
        public bool ChooseFriendTrue(NodeC n1, NodeC n2, double x, double y)
        {
            LineC l1 = new LineC(n1.x, n1.y, n2.x, n2.y);//line between nodes
            LineC l2 = new LineC(n1.x, n1.y, l1);//line normal to l1 through n1
            LineC l3 = new LineC(n2.x, n2.y, l1);//line normal to l1 through n2
            return (LineC.IsBetweenLines(x,y,l2,l3) && LineC.IsOnLine(x, y, 5000, l1));
        }

        public void ToggleRelation(double x, double y)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = i + 1; j < nodes.Count; j++)
                {
                    int c = TestEdgeIndex(i, j);
                    
                    if (ChooseFriendTrue(nodes[i], nodes[j], x, y))
                    { 
                        if (TestEdge(i, j))
                        {
                            if (nodes[i].edge[TestEdgeIndex(i, j)].relation == 3)
                            {
                                nodes[i].edge[TestEdgeIndex(i, j)].relation = 0;
                                nodes[j].edge[TestEdgeIndex(j, i)].relation = 0;
                            }
                                nodes[i].edge[TestEdgeIndex(i, j)].relation++;
                                nodes[j].edge[TestEdgeIndex(j, i)].relation++;
                        }
                    }
                }
            }
        }

        public void Group(int n)
        {
            int groupnumber = 0;
            cs = new List<NodeC>();
            groups = new List<GroupC>();
            for (int i = 0; i < nodes.Count; i++)
            {
                cs.Add(nodes[i]);
            }
            while (cs.Count != 0)
            {
                GroupsGo(cs, n, groupnumber);
                for (int i = 0; i < groups[groupnumber].nodesingroup.Count; i++)
                {
                    for (int j = 0; j < nodes.Count; j++)
                    {
                        if (groups[groupnumber].nodesingroup[i] == nodes[j]) nodes[j].GroupNumber = groupnumber + 1;
                    }
                    cs.Remove(groups[groupnumber].nodesingroup[i]);
                }
                groupnumber++;
            }
        }

        private void GroupsGo(List<NodeC> nodes, int n, int groupnumber)
        {
            groups.Add(new GroupC(nodes));
            NodeC maxenemies = groups[groupnumber].CheckMaxEnemies();
            groups.RemoveAt(groupnumber);
            groups.Add(new GroupC(new List<NodeC>()));
            groups[groupnumber].nodesingroup.Add(maxenemies);
            AddFriends(maxenemies, groupnumber, n);
            GroupColor(groupnumber);
        }

        private void AddFriends(NodeC a, int groupnumber, int n)
        {
            for (int i = 0; i < a.edge.Count; i++)
            {
                if (cs.Contains(a) && cs.Contains(a.edge[i].Neighbour))
                {
                    if (TestEdge(GetNodeIndex(a.edge[i].Neighbour), GetNodeIndex(a)) && a.edge[i].relation == 1)
                    {
                        groups[groupnumber].nodesingroup.Add(a.edge[i].Neighbour);
                    }
                }
            }
            for (int i = 0; i < groups[groupnumber].nodesingroup.Count; i++)
            {
                if (!groups[groupnumber].CheckInt(n, groups[groupnumber].NumberOfEnemies(groups[groupnumber].nodesingroup[i])))
                    groups[groupnumber].nodesingroup.Remove(groups[groupnumber].CheckMaxEnemies());
            }
        }
        private void GroupColor(int groupnumber)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = 0; j < groups[groupnumber].nodesingroup.Count; j++)
                {
                    if (nodes[i] == groups[groupnumber].nodesingroup[j])
                        nodes[i].color = Color.Gold;
                }
            }
        }
        public void SaveGraph(string FileName)
        {
            StreamWriter sw = new StreamWriter(FileName);
            sw.WriteLine(nodes.Count);
            for (int i = 0; i < nodes.Count; i++)
            {
                sw.WriteLine(nodes[i].name);
                sw.WriteLine(nodes[i].x + " " + nodes[i].y);
            }
            int[,] a = CreateMatrix();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sw.Write(a[i, j] + " ");
                }
                sw.WriteLine();
            }
            sw.Close();
        }

        public void ReadGraph(string FileName)
        {
            StreamReader sw = new StreamReader(FileName);
            nodes = new List<NodeC>();
            int a = int.Parse(sw.ReadLine());
            string name;
            int x, y;
            for (int i = 0; i < a; i++)
            {
                
                name = sw.ReadLine();
                string s = sw.ReadLine();
                string[] q = s.Split();
                x = int.Parse(q[0]);
                y = int.Parse(q[1]);
                NodeC node = new NodeC(x,y,name);
                nodes.Add(node);
            }
            int[,] c = new int[a,a];
            
            for (int i = 0; i < a; i++)
            {
                string t = sw.ReadLine();
                string[] p = t.Split();
                for (int j = 0; j < a; j++)
                {
                    c[i, j] = int.Parse(p[j]);
                }
            }
            CreateEdge(c);
            sw.Close();
        }
    }
}
