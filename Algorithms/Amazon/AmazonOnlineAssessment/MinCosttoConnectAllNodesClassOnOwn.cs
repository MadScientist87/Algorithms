using System;
namespace Algorithms.Amazon.AmazonOnlineAssessment
{
    public class MinCosttoConnectAllNodesClassOnOwn
    {
        int[] parent;
        int component;

        private int find(int v)
        {
            if (parent[v] == v) return v;
            return parent[v] = find(parent[v]);
        }


        private void Connect(int v1, int v2)
        {
            if (find(v1) == find(v2)) return;

            int root = find(v1);

            parent[v2] = root;

            --component;

        }

        private bool IsConnected(int v1, int v2)
        {
            return find(v1) == find(v2);
        }


        public int MinCosttoConnectAllNodes(int n, int[][] edges, int[][] newEdges)
        {
            component = n;
            parent = new int[n + 1];
            int cost = 0;
            for (int x = 0; x < n + 1; x++)
            {
                parent[x] = x;
            }

            foreach (int[] edge in edges)
            {
                Connect(edge[0], edge[1]);
            }

            Array.Sort(newEdges, (a, b) => a[2] - b[2]);

            foreach (int[] edge in newEdges)
            {
                if (!IsConnected(edge[0], edge[1]))
                {
                    Connect(edge[0], edge[1]);
                    cost += edge[2];
                    if (component == 1) return cost;
                }
            }
            return -1;
        }
    }
}
