using System;

public class DNode {
    public int data;
    public DNode next, prev;
    public DNode(int d) { data = d; next = prev = null; }
}

class DoublyLinkedList {
    DNode head;

    // Sona Ekleme
    public void Append(int new_data) {
        DNode new_node = new DNode(new_data);
        DNode last = head;
        new_node.next = null;

        if (head == null) {
            new_node.prev = null;
            head = new_node;
            return;
        }

        while (last.next != null) last = last.next;

        last.next = new_node;
        new_node.prev = last;
    }

    public void PrintList() {
        DNode node = head;
        Console.Write("Traversal: ");
        while (node != null) {
            Console.Write(node.data + " <-> ");
            node = node.next;
        }
        Console.WriteLine("null");
    }

    static void Main() {
        DoublyLinkedList dll = new DoublyLinkedList();
        dll.Append(10);
        dll.Append(20);
        dll.Append(30);
        Console.WriteLine("--- Doubly Linked List ---");
        dll.PrintList();
    }
}
