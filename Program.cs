using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListasTipoCola
{
    class Cola
    {
        class Nodo                // INICIO Estructura Principal
        {
            public int info;
            public Nodo sig;
        }                         // FIN    Estructura Principal

        private Nodo raiz, fondo; // El fondo se declara ya que no sabemos cual va a ser e ultimo numero
    
        public Cola()
        {                         // Se pone NULL para hacer mas eficaz el programa
            raiz = null;
            fondo = null;
        }

        public bool Vacia()
        {
            if (raiz == null) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insertar(int info)
        {
            Nodo nuevo = new();
            nuevo.info = info;
            nuevo.sig = null;

            if (Vacia()) 
            {
                raiz = nuevo;
                fondo = nuevo;
            }
        }
    }
}