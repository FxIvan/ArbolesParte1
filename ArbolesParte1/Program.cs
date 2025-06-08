using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesParte1
{
    internal class Program
    {
        // https://www.notion.so/Clase-8-rboles-1-205181e4e3b780249282eb87d0aa4544

        /*
            1. Necesitamos una abstraccion que represente NODO
               - Creamos una clase con el nombre de Nodo
               - Un nodo tendra dos descendiente, una rama izquierda y otra derecha de grado 2 que es el grado maximo que puede tener un arbol binario
               
         */
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo();
            /*
            raiz.Nombre = "A";

            // Ahora sabemos que el nodo raiz tendra una rama izquierda y derecha
            raiz.Izquierda = new Nodo();
            raiz.Izquierda.Nombre = "B";

            raiz.Derecha = new Nodo();
            raiz.Derecha.Nombre = "C";
            */
            // Completar subnodos(hijos y descendiente)
            // En la rama izquierda tiene como hijo en la rama derecha el nodo D
            /*
                  A
              ---------
             |         |
             B         C
             |         |
             --       ---
               |     |   |
                D    E   F
             */
            /*
            raiz.Izquierda.Derecha = new Nodo();
            raiz.Izquierda.Derecha.Nombre= "D";

            raiz.Derecha.Izquierda= new Nodo();
            raiz.Derecha.Izquierda.Nombre = "E";
            raiz.Derecha.Derecha = new Nodo();
            raiz.Derecha.Derecha.Nombre = "F";
            */

            // Con otro metodo
            Nodo nodoB = new Nodo();
            nodoB.Nombre = "B";

            Nodo nodoC = new Nodo();
            nodoC.Nombre = "C";

            raiz.Derecha = nodoC;
            raiz.Izquierda = nodoB;

            Nodo nodoD = new Nodo();
            nodoD.Nombre = "D";

            Nodo nodoE = new Nodo();
            nodoE.Nombre = "E";

            Nodo nodoF = new Nodo();
            nodoF.Nombre = "F";


            // Empezamos con el nodo izquierda B
            nodoB.Derecha = nodoD;

            // Ahora con el nodo derecha C
            nodoC.Izquierda = nodoE;
            nodoC.Derecha = nodoF;

        }
    }
}
