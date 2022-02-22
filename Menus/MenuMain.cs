using ToDo.Task;
using ToDo.Exceptions;
namespace ToDo.Menus
{
  public class MenuMain
  {
    public static void OptionsMenuView()
    {
      string[] options = { "1 - Nova tarefa", "2 - Editar Tarefa", "3 - Excluir Tarefa", "4 - Mostrar tarefas", "5 - Sair" };

      foreach (string n in options)
      {
        Console.WriteLine(n);
      }

      Console.WriteLine("Insira a opção: ");
      Input();
    }

    public static void Input()
    {
      string input;
      try
      {
        input = Console.ReadLine();
        InputMenu(Int32.Parse(input));
      }
      catch (InvalidCastException)
      {
        Console.WriteLine("Erro ao converter, por favor tente novamente.");
        OptionsMenuView();
      }
    }

    public static void InputMenu(int n)
    {
      Console.Clear();
      switch (n)
      {
        case 1:
          try
          {
            AddItem.addElement();
          }
          catch (Exception)
          {
            Console.WriteLine("Erro ao cadastrar");
            Console.Beep();
          }
          break;
        case 2:
          try
          {
            EditItemMenu.EditMenuItem();
          }
          catch (Exception)
          {
            Console.WriteLine("Erro ao Editar...");
            Console.Beep();
          }
          break;
        case 3:
          Task.DeleteItem.DeleteElement();
          break;
        case 4:
          Task.Item.ListElements();
          break;
        case 5:
          System.Environment.Exit(0);
          break;
        default:
          Console.WriteLine("Erro");
          Console.Beep();
          break;
      }
      OptionsMenuView();
    }
  }
}