using System;
namespace Algorithms.Amazon.AmazonOnlineAssessment
{
    public class MinCosttoConnectAllNodesClass
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
            // this while loop seems like it would never occur even when connecting edges that are the vice versa of each other
            while (v2 != parent[v2])
            {
                int temp = parent[v2];
                parent[v2] = root;
                v2 = temp;
            }
            --component;
            parent[v2] = root;
        }

        private bool isConnected(int v1, int v2)
        {
            return find(v1) == find(v2);
        }

        public int MinCosttoConnectAllNodes(int n, int[][] edges, int[][] newEdges)
        {
            parent = new int[n + 1]; component = n;
            for (int i = 0; i <= n; ++i) parent[i] = i;
            foreach (int[] edge in edges)
            {
                Connect(edge[0], edge[1]);
            }
            Array.Sort(newEdges, (a, b) => (a[2] - b[2]));
            int cost = 0;
            for (int i = 0; i < newEdges.Length; ++i)
            {
                if (!isConnected(newEdges[i][0], newEdges[i][1]))
                {
                    Connect(newEdges[i][0], newEdges[i][1]);

                    cost += newEdges[i][2];
                    if (component == 1) return cost;
                }
            }
            return -1;
        }

    }
}
