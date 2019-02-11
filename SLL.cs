namespace generic_sll
{
  public class SLL<T> 
  {
    private Node<T> _head;
    public int Size { get; set; } = 0;
    public bool HasHead
    {
      get { return _head != null; }
    }

    public SLL() { }

    public void PrintSLL()
    {
      if (HasHead)
      {
        var runner = _head;
        while (runner != null)
        {
          System.Console.WriteLine(runner.GetValueOrDefault());
          runner = runner.next;
        }
      }
    }

    public void AddToBack(T value)
    {
      Size++;
      Node<T> newNode = new Node<T>(value);
      if (HasHead)
      {
        var runner = _head;
        while (runner.next != null)
          runner = runner.next;
        runner.next = newNode;
      }
      else
        _head = newNode;
    }

    public void AddToFront(T value)
    {
      Size++;
      Node<T> newNode = new Node<T>(value);
      if (HasHead)
      {
        var temp = _head;
        _head = newNode;
        _head.next = temp;
      }
      else
        _head = newNode;
    }

    public void ReverseSLL()
    {
      if (HasHead)
      {
        Node<T> current = _head;
        Node<T> prev = null;
        Node<T> next;
        while(current != null)
        {
          next = current.next;
          current.next = prev;
          prev = current;
          current = next;
        }
        _head = prev;        
      }
    }
  }
}
