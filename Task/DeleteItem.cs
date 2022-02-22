using ToDo.Exceptions;

namespace ToDo.Task
{
  public class DeleteItem : Item
  {
    public static void DeleteElement()
    {
      if (Item.ListIsEmpty())
      {
        Console.WriteLine("Lista Vazia!");
        return;
      }
      string id;

      ListElements();
      Console.WriteLine("Insira o ID do elemento: ");

      id = Console.ReadLine();

      if (string.IsNullOrEmpty(id))
      {
        throw new NullStringException("Não é possivel deletar!");
      }

      if (int.Parse(id) < 0 || int.Parse(id) > itens.Count())
      {
        Console.WriteLine("Insira um número válido!");
        return;
      }
      RemoveTask(int.Parse(id));
    }
  }
}