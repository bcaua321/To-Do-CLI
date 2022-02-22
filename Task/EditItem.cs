using ToDo.Exceptions;
namespace ToDo.Task
{
  public class EditItem : Item
  {
    public static void EditElement(int element)
    {
      if (element < 0 || element > itens.Count())
      {
        Console.WriteLine("Insira um número válido!");
        return;
      }
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