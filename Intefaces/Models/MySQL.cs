using Intefaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intefaces.Models
{
    public class MySQL : IBaseDatos
    {

        string datos {get;set;} 
        public void Create(string Value)
        {
            datos = "MySQL " + Value;
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
            datos = "MySql " + Value;
        }
    }
}

