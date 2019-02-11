using System;

namespace generic_sll
{
  class Program
  {
    static void Main(string[] args)
    {
      var bob = new SLL<int>();
      var chuckNorris = new SLL<bool>();
      var trashPanda = new SLL<byte>();
      var nickFurry = new SLL<float>();
      var sadPanda = new SLL<string>();
      var users = new SLL<User>();

      users.AddToBack(new User("Bugs Bunny"));
      users.AddToBack(new User("Elmer Fud"));
      users.AddToBack(new User("Wile E. Coyote"));
      users.ReverseSLL();
      users.PrintSLL();

      bob.AddToBack(2);
      bob.AddToBack(1);
      bob.AddToFront(3);
      bob.AddToFront(4);
      bob.AddToFront(5);
      bob.ReverseSLL();
      bob.PrintSLL();
    }
  }
}
