using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesamientoParalelo
{
    public interface IRepository<T>
    {
        List<T> GetAllNames();
        List<T> GetNamesStartingWith(char startingChar);
    }
}
