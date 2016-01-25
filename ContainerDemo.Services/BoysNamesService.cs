namespace ContainerDemo.Services
{
    using System.Linq;
    using System.Collections.Generic;
    using ContainerDemo.Interfaces;

    public class BoysNamesService : INamesService
    {
        private static string[] _names = {
            "Oliver",
            "Jacob",
            "Jack",
            "Noah",
            "Charlie",
            "William",
            "Alfie",
            "Dylan",
            "Logan",
            "Leo",
            "Oscar" };

        public BoysNamesService()
        {
        }

        public IEnumerable<string> GetTopNames(int count = 10)
        {
            if (count > _names.Count()) count = _names.Count();

            return _names.Take(count).AsEnumerable<string>();
        }
    }
}
