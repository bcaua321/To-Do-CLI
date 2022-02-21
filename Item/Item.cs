using System;
namespace ToDo.Item
{
  public class Item
  {
    protected static List<string> itens = new List<string>();

    public static void addTask(string task)
    {
      itens.Add(task);
    }

    public static void removeTask(int element)
    {
      if (tasksEmpty()) return;
      itens.RemoveAt(element);
    }

    public static bool tasksEmpty()
    {
      if (itens.Count == 0) return true;
      return false;
    }

    public static void listElements()
    {
      int n = 0;
      foreach (string item in itens)
      {
        Console.WriteLine(n + " - " + item);
        n++;
      }
    }

  }
}