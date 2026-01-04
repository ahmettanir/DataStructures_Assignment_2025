using System;

public class CNode {
    public int data;
    public CNode next;
    public CNode(int d) { data = d; next = null; }
}

class CircularLinkedList {
    static void Main() {
        CNode head = new CNode(1);
        CNode second = new CNode(2);
        CNode third = new CNode(3);

        head.next = second;
        second.next = third;
        third.next = head; // Listenin sonu basa donuyor (Circular)

        Console.WriteLine("--- Circular Linked List Verification ---");
        Console.WriteLine($"Node 1: {head.data}");
        Console.WriteLine($"Node 2: {head.next.data}");
        Console.WriteLine($"Node 3: {head.next.next.data}");
        Console.WriteLine($"Node 3 points to: {head.next.next.next.data} (Back to Head)");
    }
}
