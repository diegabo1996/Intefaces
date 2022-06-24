using Intefaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intefaces.Models
{
    public class SQLServer : IBaseDatos
    {
        string datos = string.Empty;
        public void Create(string Value)
        {
            datos = "SQL Server " + Value;
        }

        public void Delete()
        {
            datos = string.Empty;
        }

        public string Read()
        {
            return datos;
        }

        public void Update(string Value)
        {
            datos = "SQL Server " + Value;
        }
    }
}
