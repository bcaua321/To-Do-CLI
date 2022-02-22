using ToDo.Task;
namespace ToDo.Menus
{
  public class EditItemMenu
  {
    public static void EditMenuItem()
    {
      if (Task.Item.ListIsEmpty())
      {
        Console.WriteLine("Lista vazia!");
        return;
      }

      string inputString;
      Task.Item.ListElements();
      Console.WriteLine("Insira o ID do poduto que deseja editar: ");
      try
      {
        inputString = Console.ReadLine();
        Task.EditItem.EditElement(int.Parse(inputString));
      }
      catch (InvalidCastException)
      {
        Console.WriteLine("Insira somente números!");
      }
    }
  }
}