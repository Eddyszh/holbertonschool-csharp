using System;

///<summary>
/// Generic Queue class
///</summary>
class Queue<T>
{
    ///<summary>
    /// Method to check the type
    ///</summary>
    ///<return>
    /// the type of the class
    ///</return>
    public Type CheckType()
    {
        return typeof(T);
    }

    ///<summary>
    /// Private class Node
    ///</summary>
    public class Node
    {
        ///<summary>
        /// Read-write property
        ///</summary>
        public T value;
        ///<summary>
        /// Read-write property
        ///</summary>
        public Node next { get; set; } = null;
        ///<summary>
        /// Read-write property
        ///</summary>
        public Node(T t)
        {
            value = t;
        }
    }

    ///<summary>
    /// Read-write property
    ///</summary>
    public Node head { get; set; } = null;
    ///<summary>
    /// Read-write property
    ///</summary>
    public Node tail { get; set; } = null;
    ///<summary>
    /// Read-write property
    ///</summary>
    public int count { get; set; } = 0;

    ///<summary>
    /// Enqueue method to add a node at the end
    ///</summary>
    public void Enqueue(T t)
    {
        Node n = new Node(t);
        if (head == null)
            tail = head = n;
        else
        {
            tail.next = n;
            tail = n;
        }
        count++;
    }

    ///<summary>
    /// Method to count the ammount of nodes
    ///</summary>
    ///<return>
    /// ammount of nodes
    ///</return>
    public int Count()
    {
        return count;
    }

    ///<summary>
    /// Method to remove the first node of the llist
    ///</summary>
    ///<return>
    /// removed value
    ///</return>
    public T Dequeue()
    {
        if (head != null)
        {
            T headValue = head.value;
            if (head == tail)
            {
                tail = null;
            }
            head = head.next;
            count--;
            return headValue;
        }
        else
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
    }

    ///<summary>
    /// Method to get the first value of the llist
    ///</summary>
    ///<return>
    /// first value
    ///</return>
    public T Peek()
    {
        if (head != null)
            return head.value;
        else
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
    }

    ///<summary>
    /// Method to print the llist from the head
    ///</summary>
    public void Print()
    {
        if (head != null)
        {
            Node n  = head;
            while (n != null)
            {
                Console.WriteLine(n.value);
                n = n.next;
            }
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }
    }
}
