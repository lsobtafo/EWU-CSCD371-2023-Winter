namespace GenericsHomework.Tests;

[TestClass]
public class NodeTests
{
    [TestMethod]
    public void Node_Append_Success()
    {
        Node<int> root = new Node<int>(1);
        root.Append(2);
        Assert.AreEqual(2, root.NextNode.Content);
        Assert.AreEqual(root, root.NextNode.PrevNode);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void Node_Append_DuplicateValue_ThrowsException()
    {
        Node<int> root = new Node<int>(1);
        root.Append(2);
        root.Append(2);
    }

    [TestMethod]
    public void Node_Clear_Success()
    {
        Node<int> root = new Node<int>(1);
        root.Append(2);
        root.Clear();
        Assert.IsNull(root.NextNode);
        Assert.IsNull(root.PrevNode);
    }

    [TestMethod]
    public void Node_Exists_Success()
    {
        Node<int> root = new Node<int>(1);
        root.Append(2);
        root.Append(3);
        Assert.IsTrue(root.Exists(2));
        Assert.IsFalse(root.Exists(4));
    }
}