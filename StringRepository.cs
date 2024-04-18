using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesamientoParalelo
{
    public class StringRepository : IRepository<string>
    {
        private List<string> nombres;

        public StringRepository() 
        {
            nombres = new List<string>
            {
                "Emma", "Ethan", "Ella", "Eli", "Emily", "Evan", "Eva",
                 "Olivia", "Oliver", "Oscar", "Isabella", "Ivy"
            };
        }

        public List<string> GetAllNames()
        {
            return nombres;
        }

        public List<string> GetNamesStartingWith(char startingChar)
        {
            return nombres
            .Where(name => name.StartsWith(startingChar.ToString(), StringComparison.OrdinalIgnoreCase))
            .ToList();
        }
    }
}
