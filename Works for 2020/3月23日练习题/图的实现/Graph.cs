using System;
namespace 图的实现 {
    class Graph {
        //图中所能包含的点上限
        //private int Number;
        //顶点数组
        public Vertex[] vertiexes;
        //邻接矩阵
        public int[,] matrix;
        //统计当前图中有几个点
        public int curVerNum = 0;
        //初始化图
        public Graph(int number) {
            //初始化邻接矩阵和顶点数组
            matrix = new int[number, number];
            vertiexes = new Vertex[number];
            //将代表邻接矩阵的表全初始化为0
            for (int i = 0; i < number; i++) {
                for (int j = 0; j < number; j++) {
                    matrix[i, j] = 0;
                }
            }
        }
        //向图中添加节点
        public void AddVertex(int v) {
            vertiexes[curVerNum] = new Vertex(v);
            curVerNum++;
        }
        //向图中添加有向边
        public void AddEdge(int vertex1, int vertex2) {
            matrix[vertex1, vertex2] = 1;
        }
        //显示点
        public void DisplayVert(int vertexPosition) {
            Console.WriteLine(vertiexes[vertexPosition] + " ");
        }
    }
}
