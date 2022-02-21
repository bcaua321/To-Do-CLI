namespace ToDo.Exceptions
{
  public class NullStringException : Exception
  {
    public NullStringException(string msg) : base(msg) { }
  }
}