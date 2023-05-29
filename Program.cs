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
            else
            {
                fondo.sig = nuevo;
                fondo = nuevo;
            }
        }

        public int Extraer()
        {
            if (!Vacia())
            {
                int informacion = raiz.info;

                if (raiz == fondo)
                {
                    raiz = null;
                    fondo = null;
                }
                else
                {
                    raiz = raiz.sig;
                }           

                return informacion;
            
            }
            return int.MaxValue;    // En caso de que no sea una de las opciones regresara el numero maximo
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            Console.WriteLine("Listado de los elementos > ");

            while (reco != null)
            {
                Console.WriteLine(reco.info + "- ");
                reco = reco.sig;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Cola estructura = new();

            estructura.Insertar(2);
            estructura.Insertar(3);
            estructura.Insertar(6);
            estructura.Insertar(7);
            estructura.Insertar(9);
            estructura.Insertar(10);

            estructura.Imprimir();

            Console.WriteLine("Extraemos un elemento de la estructura > " + estructura.Extraer());

            estructura.Imprimir();

            Console.ReadKey();

        }
    }
}
