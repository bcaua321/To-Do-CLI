using System;
namespace ToDo.Task
{
  public class Item
  {
    protected static List<string> itens = new List<string>();

    public static void AddTask(string task)
    {
      itens.Add(task);
    }

    public static void RemoveTask(int element)
    {
      if (TasksEmpty()) return;
      itens.RemoveAt(element);
    }

    public static bool TasksEmpty()
    {
      if (itens.Count == 0) return true;
      return false;
    }

    public static void ListElements()
    {
      if (ListIsEmpty())
      {
        Console.WriteLine("Lista vazia!");
        return;
      }

      int n = 0;
      foreach (string item in itens)
      {
        Console.WriteLine(n + " - " + item);
        n++;
      }

      Console.WriteLine();
    }

    public static bool ListIsEmpty()
    {
      if (itens.Count() == 0)
      {
        return true;
      }
      return false;
    }

  }
}