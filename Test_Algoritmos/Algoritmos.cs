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
        public static List<PROCESS> resultlista = new List<PROCESS>();
        public static List<PROCESS> tempLista = new List<PROCESS>();


        Conexion con = new Conexion();
        public Algoritmos()
        {
           
            lista = con.GetPROCESS();
           
        
        }
        public List<PROCESS> GetLista()
        {
            return resultlista;
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
               // PROCESS tempres = new PROCESS();
                if (pro.CPU > quantum)
                {
                    Console.WriteLine("Restando CPU a: " + pro.Nombre);
                    pro.Estado = "Restando CPU";
                    pro.CPU = (pro.CPU - quantum);
                   
                    if (pro.CPU > quantum) {
                        pro.Estado = "Bloqueado";
                    }
                    //Console.WriteLine("Proceso pasa a bloqueado");
                       
                    
                    else
                    {
                        Console.WriteLine("Proceso pasa a listo");
                        pro.Estado = "Listo";
                    }
                    
                    
                }
                else if (pro.CPU <= quantum)
                {
                    Console.WriteLine("Proceso terminado: " + pro.Nombre);
                    pro.CPU = (0);
                    pro.Estado="Terminado";
                }
                resultlista.Add(new PROCESS
                {
                    ID = pro.ID,
                    Nombre = pro.Nombre,
                    CPU = pro.CPU,
                    Prioridad = pro.Prioridad,
                    TiLLegada = pro.TiLLegada,
                   Estado=pro.Estado,
                });
                finIteraciones = true;

                for (int i = 0; i < lista.Count; i++)
                    if (lista[i].CPU > 0)
                        finIteraciones = false;
            }
        }

        internal void CPU(int Quantum)
        {
            int quantum = Quantum, pos = 0;
            bool finIteraciones = false, turno = true; //turno = true, 1er elemento, turno = false, 2do elementa
            PROCESS pro=null;
            for (int j = 0; j <= lista.Count - 2; j++)
            {
                for (int i = 0; i <= lista.Count - 2; i++)
                {
                    if (lista[i].CPU > lista[i + 1].CPU)
                    {
                        PROCESS temp = lista[i + 1];
                        lista[i + 1] = lista[i];
                        lista[i] = temp;
                    }
                }
            }

            while (!finIteraciones)
            {
                pro = lista[lista.Count-1];
               
                if (pos < lista.Count)
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (lista[pos].CPU == 0)
                            pos++;
                        else
                            break;
                    }


                    if (lista[pos].CPU > quantum)
                    {
                        Console.WriteLine("Proceso en listo" + lista[pos].Nombre);

                        pro.Estado = " Listo";
                        pro.Nombre = lista[pos].Nombre;
                        resultlista.Add(new PROCESS
                        {
                           
                            Nombre = pro.Nombre,
                         
                            Prioridad = pro.Prioridad,
                            TiLLegada = pro.TiLLegada,
                            Estado = pro.Estado,
                        });
                        Console.WriteLine("En ejecucion proceso: " + lista[pos].Nombre);
                        pro.Estado = " Ejecucion";
                        pro.Nombre = lista[pos].Nombre;
                        resultlista.Add(new PROCESS
                        {
                      
                            Nombre = pro.Nombre,
                          
                            Prioridad = pro.Prioridad,
                            TiLLegada = pro.TiLLegada,
                            Estado = pro.Estado,
                        });
                        lista[pos].CPU=(lista[pos].CPU - quantum);

                        pro.CPU=lista[pos].CPU = (lista[pos].CPU - quantum);
                        resultlista.Add(new PROCESS
                        {
                           
                            Nombre = pro.Nombre,
                           
                            Prioridad = pro.Prioridad,
                            TiLLegada = pro.TiLLegada,
                            Estado = pro.Estado,
                        });
                        if (lista[pos].CPU > quantum) {
                            Console.WriteLine("El proceso pasa a bloqueo" + lista[pos].Nombre);
                            pro.Estado = " Bloqueo";
                            pro.Nombre = lista[pos].Nombre;
                            resultlista.Add(new PROCESS
                            {

                                Nombre = pro.Nombre,

                                Prioridad = pro.Prioridad,
                                TiLLegada = pro.TiLLegada,
                                Estado = pro.Estado,
                            });
                        }
                          

                    }
                    else if (lista[pos].CPU <= quantum)
                    {
                        Console.WriteLine("Proceso en listo" + lista[pos].Nombre);
                        pro.Estado = " Listo";
                        pro.Nombre = lista[pos].Nombre;
                        resultlista.Add(new PROCESS
                        {
                           
                            Nombre = pro.Nombre,
                            CPU = pro.CPU,
                            Prioridad = pro.Prioridad,
                            TiLLegada = pro.TiLLegada,
                            Estado = pro.Estado,
                        });
                        Console.WriteLine("En ejecucion: " + lista[pos].Nombre);
                        lista[pos].CPU=0;
                        pro.CPU = lista[pos].CPU;
                        pro.Nombre = lista[pos].Nombre;
                        pro.Estado = " Ejecucion";
                        resultlista.Add(new PROCESS
                        {
                           
                            Nombre = pro.Nombre,
                            
                            Prioridad = pro.Prioridad,
                            TiLLegada = pro.TiLLegada,
                            Estado = pro.Estado,
                        });
                        Console.WriteLine("Proceso terminado" + lista[pos].Nombre);
                        pro.Estado = "Terminado";
                        pro.Nombre = lista[pos].Nombre;
                        resultlista.Add(new PROCESS
                        {
                            
                            Nombre = pro.Nombre,
                            
                            Prioridad = pro.Prioridad,
                            TiLLegada = pro.TiLLegada,
                            Estado = pro.Estado,
                        });
                    }

                    if (turno)
                    {
                        pos++;
                        turno = false;
                    }
                    else
                    {
                        pos--;
                        turno = true;
                    }

                    finIteraciones = true;

                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (lista[i].CPU > 0)
                            finIteraciones = false;
                    }
                }
                if (pos == lista.Count)
                    break;
            }
            resultlista.Add(new PROCESS
            {
              
                Nombre = pro.Nombre,
                
                Prioridad = pro.Prioridad,
                TiLLegada = pro.TiLLegada,
                Estado = pro.Estado,
            });

            pos--;
            while (lista[pos].CPU > 0)
            {
                if (lista[pos].CPU > quantum)
                {
                    Console.WriteLine("Proceso en listo" + lista[pos].Nombre);
                    pro.Estado = " Listo";
                    pro.Nombre = lista[pos].Nombre;
                    resultlista.Add(new PROCESS
                    {
                       
                        Nombre = pro.Nombre,
                        
                        Prioridad = pro.Prioridad,
                        TiLLegada = pro.TiLLegada,
                        Estado = pro.Estado,
                    });
                    Console.WriteLine("En ejecucion proceso: " + lista[pos].Nombre);
                    pro.Estado = " Ejecucion";
                    pro.Nombre = lista[pos].Nombre;
                    resultlista.Add(new PROCESS
                    {
                        
                        Nombre = pro.Nombre,
                       
                        Prioridad = pro.Prioridad,
                        TiLLegada = pro.TiLLegada,
                        Estado = pro.Estado,
                    });
                    lista[pos].CPU=(lista[pos].CPU - quantum);
                    if (lista[pos].CPU > quantum) {
                        Console.WriteLine("El proceso pasa a bloqueo" + lista[pos].Nombre);
                        pro.Estado = " Bloqueo";
                        pro.Nombre = lista[pos].Nombre;
                        resultlista.Add(new PROCESS
                        {

                            Nombre = pro.Nombre,

                            Prioridad = pro.Prioridad,
                            TiLLegada = pro.TiLLegada,
                            Estado = pro.Estado,
                        });
                    }
                      
                }
                else if (lista[pos].CPU <= quantum)
                {
                    Console.WriteLine("Proceso en listo" + lista[pos].Nombre);
                    pro.Nombre = lista[pos].Nombre;
                    resultlista.Add(new PROCESS
                    {
                       
                        Nombre = pro.Nombre,
                      
                        Prioridad = pro.Prioridad,
                        TiLLegada = pro.TiLLegada,
                        Estado = pro.Estado,
                    });
                    Console.WriteLine("En ejecucion: " + lista[pos].Nombre);
                    pro.Nombre = lista[pos].Nombre;
                    lista[pos].CPU=0;
                    pro.CPU = lista[pos].CPU;
                    resultlista.Add(new PROCESS
                    {
                      
                        Nombre = pro.Nombre,
                        
                        Prioridad = pro.Prioridad,
                        TiLLegada = pro.TiLLegada,
                        Estado = pro.Estado,
                    });
                    Console.WriteLine("Proceso terminado" + lista[pos].Nombre);
                    pro.Nombre = lista[pos].Nombre;
                    resultlista.Add(new PROCESS
                    {
                       
                        Nombre = pro.Nombre,
                       
                        Prioridad = pro.Prioridad,
                        TiLLegada = pro.TiLLegada,
                        Estado = pro.Estado,
                    });
                }
                resultlista.Add(new PROCESS
                {
                    
                    Nombre = pro.Nombre,
                    
                    Prioridad = pro.Prioridad,
                    TiLLegada = pro.TiLLegada,
                    Estado = pro.Estado,
                });
            }
            Console.WriteLine("Aqui inicia");

            foreach (var item in resultlista)
            {
                Console.WriteLine(item.Nombre);
            }
            Console.WriteLine("Aqui inicia" + GetLista());
        }

        internal void RoundRobin(int Quantum)
        {
            int quantum = Quantum, tiempoGlobal = 0, contadorQ = 0; //contadorQuantum
            bool finIteraciones = false;
            List<PROCESS> tempLista = new List<PROCESS>();

            while (!finIteraciones)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].TiLLegada== tiempoGlobal)
                    {
                        Console.WriteLine("Insertando proceso: " + lista[i].Nombre + " tiempo " + tiempoGlobal);
                        tempLista.Add(lista[i]);
                        lista.RemoveAt(i);
                    }
                }


                if (contadorQ == tempLista[0].CPU)
                {
                    Console.WriteLine("Proceso terminado: " + tempLista[0].Nombre + " tiempo: " + tiempoGlobal);

                    tempLista.RemoveAt(0);
                    contadorQ = 0;
                }
                else if (contadorQ - quantum == 0)
                {
                    Console.WriteLine("Ejecutando CPU proceso: " + tempLista[0].Nombre + " tiempo: " + tiempoGlobal);
                    tempLista[0].CPU=(tempLista[0].CPU - quantum);
                    Console.WriteLine("CPU restante: " + tempLista[0].CPU);

                    if (tempLista[0].CPU > quantum && tempLista[0].CPU != 0)
                        Console.WriteLine("El proceso pasa a bloqueado");
                    else if (tempLista[0].CPU != 0)
                        Console.WriteLine("El proceso pasa a listo");

                    tempLista.Add(tempLista[0]);
                    tempLista.RemoveAt(0);
                    contadorQ = 0;
                }

                tiempoGlobal++;
                contadorQ++;


                if (tempLista.Count == 0)
                    finIteraciones = true;
            }



        }
        internal void ProcMasCortoContinuacion()
        {
            int tiempoGlobal = 0, posProceso, compararCPU;
            //Utilizamos el atributo CPU como rafaga ya que era mas conveniente
            bool finIteraciones = false;
            PROCESS pro = null;
            while (!finIteraciones)
            {
                posProceso = 0;
                compararCPU = -1; /*Cuando compararCPU permanezca en -1 implica que ningun proceso a llegado a la cola
                suponga P1->CPU:5, Ins:0; P2->CPU:3, Ins:6; En este caso se ejecutaria el proceso P1 primero, al terminar
                proceso P1 tiempoGlobal transcurrido seria de 5, sin embargo P2 no entra hasta el tiempo 6*/

                for (int i = 0; i < lista.Count; i++)
                {
                    if (compararCPU == -1 && lista[i].TiLLegada <= tiempoGlobal)
                    {
                        posProceso = i;
                        compararCPU = (int)lista[i].CPU;
                    }
                    else if (lista[i].CPU < compararCPU && lista[i].TiLLegada<= tiempoGlobal)
                    {
                        posProceso = i;
                        compararCPU = (int)lista[i].CPU;
                    }

                }
                pro = lista[lista.Count - 1];
                if (compararCPU != -1)
                {
                    Console.WriteLine("Nombre proceso ejecutado: " + lista[posProceso].Nombre);
                    tiempoGlobal += (int)lista[posProceso].CPU;
                    pro.Estado = " Ejecutado";
                    pro.Nombre = lista[posProceso].Nombre;
                    pro.TiLLegada= tiempoGlobal;
                    Console.WriteLine("Termina en T: " + tiempoGlobal);

                    lista.RemoveAt(posProceso);
                    resultlista.Add(new PROCESS
                    {

                        Nombre = pro.Nombre,

                        Prioridad = pro.Prioridad,
                        TiLLegada = pro.TiLLegada,
                        Estado = pro.Estado,
                    });
                }
                else
                    tiempoGlobal += 1;

                if (lista.Count == 0)
                    finIteraciones = true;
            }
        }
        //public static void PlanifGarantizada()
        //{
        //    //Solo toma en cuenta la rafaga de CPU y la instancia de llegada
        //    int tiempoGlobal = 0;
        //    double quantum = 4, recibeQuantum = 0.00, n = 0; //En donde n es la cantidad de procesos
        //    bool finIteraciones = false;

        //    double AlgoPlaniCPU = 0.00;
        //    //Algoritmo de burbuja para ordenarlos por instancia de llegada
        //    for (int j = 0; j <= lista.Count - 2; j++)
        //    {
        //        for (int i = 0; i <= lista.Count - 2; i++)
        //        {
        //            if (lista[i].TiLLegada > lista[i + 1].TiLLegada)
        //            {
        //                PROCESS temp = lista[i + 1];
        //                lista[i + 1] = lista[i];
        //                lista[i] = temp;
        //            }
        //        }
        //    }

        //    while (!finIteraciones)
        //    {

        //        n = 0;

        //        for (int i = 0; i < lista.Count; i++)
        //        {
        //            if (lista[i].TiLLegada <= tiempoGlobal && lista[i].AlgoPlaniCPU > 0)
        //            {
        //                //Console.WriteLine("Evaluando proceso " + lista[i].getNombre());
        //                n++;
        //            }
        //        }

        //        Console.WriteLine("Cantidad de procesos: " + n + " tiempo: " + tiempoGlobal);
        //        recibeQuantum = ((1 / n) * quantum);

        //        for (int i = 0; i < lista.Count; i++)
        //        {
        //            if (lista[i].getILlegada() <= tiempoGlobal && lista[i].getAlgoPlaniCPU() > 0)
        //            {
        //                if (lista[i].getAlgoPlaniCPU() > recibeQuantum)
        //                {
        //                    Console.WriteLine("Proceso: " + lista[i].getNombre());
        //                    lista[i].setAlgoPlaniCPU(lista[i].getAlgoPlaniCPU() - recibeQuantum);
        //                    Console.WriteLine("Se le resto: " + recibeQuantum + " quantum restante: " + lista[i].getAlgoPlaniCPU());
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Proceso terminado: " + lista[i].Nombre);
        //                    lista[i].setAlgoPlaniCPU(0);
        //                }
        //            }
        //        }

        //        finIteraciones = true;

        //        for (int i = 0; i < lista.Count; i++)
        //        {
        //            if (lista[i].getAlgoPlaniCPU() > 0)
        //                finIteraciones = false;
        //        }

        //        tiempoGlobal++;
        //    }

        //}
        //public static void AlgorPorLoteria(int Quantum)
        //{
        //    int quantum = Quantum, sumPrioridad, porcentaje, loteria;
        //    double ticket = 10;
        //    Random random = new Random();
        //    bool procesoTerminado, finIteraciones = false;

        //    while (!finIteraciones)
        //    {
        //        sumPrioridad = 0;
        //        porcentaje = 100;
        //        finIteraciones = false;
        //        procesoTerminado = false;

        //        for (int i = 0; i < lista.Count; i++)
        //        {
        //            sumPrioridad += (int)lista[i].Prioridad;
        //        }
        //        Console.WriteLine("SumPrioridad " + sumPrioridad);

        //        porcentaje /= sumPrioridad;
        //        Console.WriteLine("Porcentaje: " + porcentaje);

        //        for (int i = 0; i < lista.Count; i++)
        //        {
        //            lista[i].Probabilidad=porcentaje * lista[i].Prioridad);
        //            if (i == 0)
        //                lista[i].setTicket(Convert.ToInt32(Math.Round(lista[i].getProbabilidad() / ticket)));
        //            else
        //                lista[i].setTicket(lista[i - 1].getTicket() + Convert.ToInt32(Math.Round(lista[i].getProbabilidad() / ticket)));
        //        }
        //        Console.WriteLine("Num ticket para ultimo proceso: " + lista[^1].getTicket()); //-> lista[lista.Count-1].getTicket()

        //        while (!procesoTerminado)
        //        {
        //            loteria = random.Next(1, lista[lista.Count - 1].getTicket());
        //            Console.WriteLine("Loteria: " + loteria);

        //            for (int i = 0; i < lista.Count; i++)
        //            {
        //                if (loteria <= lista[i].getTicket())
        //                {
        //                    if (lista[i].CPU < quantum)
        //                        lista[i].CPU=0;
        //                    else
        //                        lista[i].setCPU(lista[i].getCPU() - quantum);
        //                    Console.WriteLine("Se resto CPU a proceso: " + lista[i].Nombre + " - " + lista[i].CPU);

        //                    if (lista[i].CPU > quantum && lista[i].CPU != 0)
        //                        Console.WriteLine("El proceso pasa a bloqueado");
        //                    else if (lista[i].CPU != 0)
        //                        Console.WriteLine("El proceso pasa a listo");

        //                    if (lista[i].CPU == 0)
        //                    {
        //                        Console.WriteLine("El proceso " + lista[i].Nombre + " se ha terminado");
        //                        lista.RemoveAt(i);
        //                        procesoTerminado = true;
        //                    }
        //                    break;
        //                }
        //            }
        //        }

        //        if (lista.Count == 0)
        //            finIteraciones = true;

        //    }
        }
    }

