using System.Collections;

var list = new SinglyLinkedList<string>();

list.AddToFront("a");
list.AddToFront("b");
list.AddToFront("c");
Console.WriteLine("contains b? " +list.Contains("b"));
Console.WriteLine("contains d? " +list.Contains("d"));
list.Add("d");
list.Add("e");
list.Remove("c");
list.Remove("a");


foreach (var item in list)
{
    Console.WriteLine(item);    
}  

Console.ReadKey();

public class SinglyLinkedList<T> : ILinkedList<T?>
{
    private Node<T>? _head;
    private int _count;

    public int Count => _count;

    public bool IsReadOnly => false;

    public void Add(T? item)
    {
        AddToEnd(item);
    }

    public void AddToEnd(T? item)
    {
        var newNode = new Node<T>(item);
        if (_head is null)
        {
            _head = newNode;
        }
        else
        {
            var tail = GetNodes().Last();
            tail.Next = newNode;    
        }
        ++_count;
    }

    public void AddToFront(T? item)
    {
        
        var newHead = new Node<T>(item)
        {
            Next = _head,
        };
        _head = newHead;
        ++_count;
    }

    public void Clear()
    {
        Node<T>? current = _head;
        while (current is not null)
        {
            Node<T>? temporary = current;
            current.Next = null;
            temporary.Next = null;
        }
        _head = null;
        _count = 0;
    }

    public bool Contains(T? item)
    {
        if (item is null)
        {
            return GetNodes().Any(node => item!.Equals(null));
        }
        return GetNodes().Any(node => item.Equals(node.Value));
    }

    public void CopyTo(T?[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(T? item)
    {
        Node<T>? predecessor = null;
        foreach (var node in GetNodes())
        {
            if ((node.Value is null && item is null) ||
                (node.Value is not null && node.Value.Equals(item)))
            {
                if (predecessor is null)
                {
                    _head = node.Next;
                }
                else
                { 
                    predecessor.Next = node.Next;
                }
                --_count;
                return true;
            }
            predecessor = node;
        }
        return false;
    }

    public IEnumerator<T?> GetEnumerator()
    {
        foreach (var node in GetNodes())
        {
            yield return node.Value;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private IEnumerable<Node<T>> GetNodes()
    {
        if (_head is null)
	    {
            yield break;
	    }
        Node<T>? current = _head;
        while (current is not null)
        {
            yield return current;
            current = current.Next;
        }
    }
}
