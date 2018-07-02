using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGraphsProgram
{
    class GroupC
    {
        public List<NodeC> nodesingroup;
        public GroupC(List<NodeC> nodesingroup)
        {
            this.nodesingroup = nodesingroup;
        }

        public NodeC CheckMaxEnemies()
        {
            int _count, count = int.MinValue, number = -1;
            for (int i = 0; i < nodesingroup.Count; i++)
            {
                _count = 0;
                for (int j = 0; j < nodesingroup[i].edge.Count; j++)
                {
                    if (nodesingroup[i].edge[j].relation == 2)
                        _count++;
                }
                if (_count >= count)
                {
                    count = _count;
                    number = i;
                }
            }
            if (number != -1)
                return nodesingroup[number];
            return null;
        }

        public int NumberOfEnemies(NodeC a)
        {
            int count = 0;
                for (int i = 0; i < a.edge.Count; i++)
                {
                    if (nodesingroup.Contains(a.edge[i].Neighbour) && a.edge[i].relation == 2)
                        count++;
                }
            return count;
        }

        public bool TestEdge(int n1, int n2)
        {
           
                int len = nodesingroup[n1].edge.Count;
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < nodesingroup[n2].edge.Count; j++)
                    {
                        if (nodesingroup[n1].edge[i].Neighbour == nodesingroup[n2] && nodesingroup[n2].edge[j].Neighbour == nodesingroup[n1])
                            return true;
                    }
                } 
            return false;
        }

        public bool CheckInt(int a, int count)
        {
            if (count > a) return false;
            return true;
        }
    }
}
