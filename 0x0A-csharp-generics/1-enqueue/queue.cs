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
    /// Enqueue method
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
}
