namespace ContainerDemo.Services.Localized
{
    using System.Linq;
    using System.Collections.Generic;
    using ContainerDemo.Interfaces;

    public class LocalizedBoysNamesService : INamesService
    {
        private static string[] _names = {
            "Aron",
            "Alexander",
            "Viktor",
            "Kristian",
            "Jón",
            "Kristófer",
            "Gunnar",
            "Ólafur",
            "Benedikt",
            "Dagur",
            "Emil"
        };

        public LocalizedBoysNamesService()
        {
        }

        public IEnumerable<string> GetTopNames(int count = 10)
        {
            if (count > _names.Count()) count = _names.Count();

            return _names.Take(count).AsEnumerable<string>();
        }
    }
}