using ToDo.Exceptions;

namespace ToDo.Item
{
  public class DeleteItem : Item
  {
    public static void DeleteElement()
    {
      string id;

      listElements();
      Console.WriteLine("Insira o ID do elemento: ");

      id = Console.ReadLine();

      if (string.IsNullOrEmpty(id))
      {
        throw new NullStringException("Não é possivel deletar!");
      }

      removeTask(int.Parse(id));
    }
  }
}