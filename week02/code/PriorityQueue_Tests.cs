using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items with distinct priorities: Low(1), Medium(3), High(5).
    // Expected Result: Dequeue returns "High","Medium","Low" in that order, then Dequeue throws.
    // Defect(s) Found: Dequeue did not remove items; loop bounds skipped last element; ties handled incorrectly.
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("Medium", 3);
        pq.Enqueue("High", 5);

        Assert.AreEqual("High", pq.Dequeue());
        Assert.AreEqual("Medium", pq.Dequeue());
        Assert.AreEqual("Low", pq.Dequeue());
        Assert.ThrowsException<InvalidOperationException>(() => pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue items with same high priority: A(4), B(4), then C(2).
    // Expected Result: Dequeue returns "A","B","C" in FIFO order among ties.
    // Defect(s) Found: >= comparison caused later duplicates to be chosen first.
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 4);
        pq.Enqueue("B", 4);
        pq.Enqueue("C", 2);

        Assert.AreEqual("A", pq.Dequeue());
        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
    }
    // Add more test cases as needed below.
}