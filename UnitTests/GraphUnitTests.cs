using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSet.DataStructures;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class GraphUnitTests
    {
        [TestMethod]
        public void Graph_Node_Addition()
        {
            // Arrange
            Graph<string> graph = new Graph<string>(false);

            // Act
            graph.AddGraphNode("A");
            graph.AddGraphNode("B");
            graph.AddGraphNode("C");
            graph.AddGraphNode("D");

            // Assert
            Assert.AreEqual(4, graph.Nodes.Count);
            Assert.IsTrue(graph.Nodes.Exists(n => n.Data == "A"));
            Assert.IsTrue(graph.Nodes.Exists(n => n.Data == "B"));
            Assert.IsTrue(graph.Nodes.Exists(n => n.Data == "C"));
            Assert.IsTrue(graph.Nodes.Exists(n => n.Data == "D"));
        }

        [TestMethod]
        public void Graph_NodeEdge_Addition()
        {
            // Arrange
            Graph<string> graph = new Graph<string>(false);

            // Act
            GraphNode<string> nodeA = graph.AddGraphNode("A");
            GraphNode<string> nodeB = graph.AddGraphNode("B");
            GraphNode<string> nodeC = graph.AddGraphNode("C");
            GraphNode<string> nodeD = graph.AddGraphNode("D");

            graph.AddGraphEdge(nodeA, nodeD, 2);
            graph.AddGraphEdge(nodeC, nodeB, 5);
            graph.AddGraphEdge(nodeB, nodeD, 3);


            // Assert
            Assert.AreEqual(4, graph.Nodes.Count);
            Assert.IsTrue(graph.Nodes.Exists(n => n.Data == "A"));
            Assert.IsTrue(graph.Nodes.Exists(n => n.Data == "B"));
            Assert.IsTrue(graph.Nodes.Exists(n => n.Data == "C"));
            Assert.IsTrue(graph.Nodes.Exists(n => n.Data == "D"));
            
            List<GraphEdge<string>> allEdges = graph.AllEdges();
            Assert.AreEqual(3, allEdges.Count);
            allEdges = graph.AllEdgesSorted();
            Assert.AreEqual(3, allEdges.Count);
        }
    }
}
