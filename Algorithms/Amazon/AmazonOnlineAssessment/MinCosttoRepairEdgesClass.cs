using System;
using System.Linq;
using System.Collections.Generic;

namespace Algorithms.Amazon.AmazonOnlineAssessment
{
    public class MinCosttoRepairEdgesClass
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

        public int MinCosttoConnectAllNodes(int n, int[][] edges, int[][] edgesToRepair)
        {
            component = n;
            parent = new int[n + 1];
            int cost = 0;
            for (int x = 0; x < n + 1; x++)
            {
                parent[x] = x;
            }

            HashSet<string> edgeExcludeList = new HashSet<string>();
            for (int i = 0; i < edgesToRepair.Length; i++)
            {
                edgeExcludeList.Add($"{edgesToRepair[i][0]},{edgesToRepair[i][1]}");
            }

            foreach (int[] edge in edges)
            {
                if (edgeExcludeList.Contains($"{edge[0]},{edge[1]}"))
                    continue;

                Connect(edge[0], edge[1]);
            }

            Array.Sort(edgesToRepair, (a, b) => a[2] - b[2]);

            foreach (int[] edge in edgesToRepair)
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
