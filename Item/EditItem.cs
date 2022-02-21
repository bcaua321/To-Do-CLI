using ToDo.Exceptions;
namespace ToDo.Item
{
  public class EditTask : Item
  {
    public static void EditElement(int element)
    {
      string task = itens[element];
      Console.WriteLine(task);
      Console.WriteLine("Insira o novo elemento: ");

      task = Console.ReadLine();

      if (string.IsNullOrEmpty(task))
      {
        throw new NullStringException("Não é possivel deletar essa task!");
      }

      itens[element] = task;
    }
  }
}