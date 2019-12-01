using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._134_有向路径检查 {
    public class UndirectedGraphNode {
        public int label;
        public IList<UndirectedGraphNode> neighbors;
        public UndirectedGraphNode(int x) {
            label = x;
            neighbors = new List<UndirectedGraphNode>();
        }
    }
    class Program {
        static void Main(string[] args) {
        }
        public bool checkPath(UndirectedGraphNode a, UndirectedGraphNode b) {
            return check(a, b) || check(b, a);
        }

        private bool check(UndirectedGraphNode a, UndirectedGraphNode b) {
            if (a == null || b == null) return false;

            HashSet<int> set = new HashSet<int>();
            Queue<UndirectedGraphNode> queue = new Queue<UndirectedGraphNode>();
            queue.Enqueue(a);
            set.Add(a.label);
            while (queue.Count != 0) {
                UndirectedGraphNode tmp = queue.Dequeue();
                if (tmp.label == b.label) return true;
                set.Add(tmp.label);
                foreach (var i in tmp.neighbors) {
                    if (i == null) continue;
                    if (set.Contains(i.label)) continue;
                    queue.Enqueue(i);
                }
            }
            return false;
        }
    }
}
