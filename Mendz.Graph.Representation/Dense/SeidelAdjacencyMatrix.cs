using System;

namespace Mendz.Graph.Representation.Dense
{
    /// <summary>
    /// Implements a Seidel adjacency matrix of a simple graph.
    /// </summary>
    public class SeidelAdjacencyMatrix : AdjacencyMatrixBase<int>
    {
        /// <summary>
        /// Constructor to create a Seidel adjacency matrix of a simple graph.
        /// </summary>
        /// <param name="graph">The graph.</param>
        public SeidelAdjacencyMatrix(Graph graph) 
            : base(graph, (z, edge) => -1, 1)
        {
        }

        protected override void SetEntries(int[,] matrix, int x, int y, int value, bool directed)
        {
            if (x == y)
            {
                throw new InvalidOperationException("Loops are not supported.");
            }
            if (directed)
            {
                throw new InvalidOperationException("Directed edges are not supported.");
            }
            matrix[x, y] = value;
            matrix[y, x] = value;
        }
    }
}
