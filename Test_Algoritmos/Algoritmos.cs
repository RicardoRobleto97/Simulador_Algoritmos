using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Algoritmos
{
     class Algoritmos
    {
        public static List<PROCESS> lista = new List<PROCESS>();
        Conexion con = new Conexion();
        public Algoritmos()
        {
            //lista.Add(new Proceso("A", 7, 2, 0));
            //lista.Add(new Proceso("B", 4, 3, 6));
            //lista.Add(new Proceso("C", 6, 4, 4));
            //lista.Add(new Proceso("D", 5, 1, 5));
            //lista.Add(new Proceso("E", 3, 5, 3));

            lista = con.GetPROCESS();
        
        
        }

        internal void Prioridad(int Quantum)
        {
            int quantum = Quantum;

            bool finIteraciones = false;
            PROCESS pro = null, proAnterior = null;

            for (int j = 0; j <= lista.Count - 2; j++)
            {
                for (int i = 0; i <= lista.Count - 2; i++)
                {
                    if (lista[i].Prioridad > lista[i + 1].Prioridad)
                    {
                        PROCESS temp = lista[i + 1];
                        lista[i + 1] = lista[i];
                        lista[i] = temp;
                    }
                }
            }

            while (!finIteraciones)
            {
                pro = lista[lista.Count - 1];

                for (int i = lista.Count - 1; i >= 0; i--)
                {
                    if (proAnterior == null)
                    {
                        if (lista[i].Prioridad <= pro.Prioridad)
                            pro = lista[i];
                    }
                    else
                    {
                        if (!proAnterior.Nombre.Equals(lista[i].Nombre) && lista[i].CPU> 0 &&
                            lista[i].Prioridad <= pro.Prioridad)
                            pro = lista[i];
                    }
                }

                proAnterior = pro;

                if (pro.CPU> quantum)
                {
                    Console.WriteLine("Restando CPU a: " + pro.Nombre);
                    pro.CPU = (pro.CPU - quantum);
                    if (pro.CPU > quantum)
                        Console.WriteLine("Proceso pasa a bloqueado");
                    else
                        Console.WriteLine("Proceso pasa a listo");
                }
                else if (pro.CPU <= quantum)
                {
                    Console.WriteLine("Proceso terminado: " + pro.Nombre);
                    pro.CPU = (0);
                }
                finIteraciones = true;

                for (int i = 0; i < lista.Count; i++)
                    if (lista[i].CPU > 0)
                        finIteraciones = false;
            }
        }

    }
}
