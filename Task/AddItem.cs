using ToDo.Exceptions;
namespace ToDo.Task
{
  public class AddItem : Item
  {
    public static void addElement()
    {
      Console.Clear();
      string task;
      Console.WriteLine("Digite a task: ");
      task = Console.ReadLine();

      if (string.IsNullOrEmpty(task))
      {
        throw new NullStringException("Não é possivel adicionar task vazia!");
      }

      AddTask(task);
      Console.Beep();
    }
  }
}