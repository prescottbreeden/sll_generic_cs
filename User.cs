namespace generic_sll
{
  public class User
  {
    public int Id { get; set; } = 0;
    public string Name { get; set; }
    public User(string name)
    {
      Name = name;
    }

    public override string ToString()
    {
      return $"ID: {Id} - Name: {Name}";
    }
  }
}
