using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intefaces.Interfaces
{
    public interface IBaseDatos
    {
        void Create(string Value);
        string Read();
        void Update(string Value);
        void Delete();
    }
}
