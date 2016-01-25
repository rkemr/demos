namespace ContainerDemo.Services
{
    using System.Linq;
    using System.Collections.Generic;
    using ContainerDemo.Interfaces;

    public class GirlsNamesService : INamesService
    {
        private static string[] _names = {
            "Amelia",
            "Olivia",
            "Isla",
            "Ava",
            "Emily",
            "Mia",
            "Ruby",
            "Evie",
            "Lily",
            "Poppy" };

        public GirlsNamesService()
        {
        }

        public IEnumerable<string> GetTopNames(int count = 10)
        {
            if (count > _names.Count()) count = _names.Count();

            return _names.Take(count).AsEnumerable<string>();
        }
    }
}
