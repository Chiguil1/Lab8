using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Notas
    {
        string nombre;
        List<int> notasA;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<int> NotasA { get => notasA; set => notasA = value; }
    }
}
