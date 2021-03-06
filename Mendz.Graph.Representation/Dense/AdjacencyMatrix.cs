namespace Mendz.Graph.Representation.Dense
{
    /// <summary>
    /// Implements an adjacency matrix.
    /// </summary>
    public class AdjacencyMatrix : AdjacencyMatrixBase<int>
    {
        /// <summary>
        /// Constructor to create an adjacency matrix.
        /// </summary>
        /// <param name="graph">The graph.</param>
        public AdjacencyMatrix(Graph graph)
            : base(graph, (z, edge) => 1)
        {
        }
    }
}
