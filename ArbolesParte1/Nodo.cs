using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesParte1
{
    internal class Nodo
    {
        // Codigo base de nuestro arbol
        // Nombre que nos ayudara a identificar el noddo
        public string Nombre { get; set; }
        // Rama que puede ser izquierda o la rama derecha
        public Nodo Izquierda { get; set; }
        public Nodo Derecha { get; set; }

    }
}
