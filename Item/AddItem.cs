using ToDo.Exceptions;
namespace ToDo.Item
{
  public class AddItem : Item
  {
    public static void addElement()
    {
      string task;
      Console.WriteLine("Digite a task: ");
      task = Console.ReadLine();

      if (string.IsNullOrEmpty(task))
      {
        throw new NullStringException("Não é possivel adicionar task vazia!");
      }
      addTask(task);
    }
  }
}