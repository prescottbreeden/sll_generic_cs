namespace generic_sll
{
  public class Node<T>
  {
    private object _value;
    public Node<T> next { get; set; }
    public bool HasValue
    {
      get { return _value != null; }
    }

    public Node(T value)
    {
      _value = value;
    }

    public T GetValueOrDefault()
    {
      if (HasValue)
        return (T)_value;
      return default(T);
    }
  }
}
