using ToDo.Exceptions;

namespace ToDo.Task
{
  public class DeleteItem : Item
  {
    public static void DeleteElement()
    {
      string id;

      ListElements();
      Console.WriteLine("Insira o ID do elemento: ");

      id = Console.ReadLine();

      if (string.IsNullOrEmpty(id))
      {
        throw new NullStringException("Não é possivel deletar!");
      }

      RemoveTask(int.Parse(id));
    }
  }
}