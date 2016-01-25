namespace ContainerDemo.Interfaces
{
    using System.Collections.Generic;

    public interface INamesService
    {
        IEnumerable<string> GetTopNames(int count = 10);
    }
}
