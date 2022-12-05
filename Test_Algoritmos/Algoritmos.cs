using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Algoritmos
{
    class Algoritmos
    {
        public static List<PROCESS> lista = new List<PROCESS>();
        public static List<PROCESS> resultlista = new List<PROCESS>();
        //public static List<PROCESS> tempLista = new List<PROCESS>();


        Conexion con = new Conexion();
        //TABLA ENTRADA
        public Algoritmos()
        {

            lista = con.GetPROCESS();


        }
        //TABLA RESULTADO
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
                        if (!proAnterior.Nombre.Equals(lista[i].Nombre) && lista[i].CPU > 0 &&
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

                    if (pro.CPU > quantum)
                    {
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
                    pro.Estado = "Terminado";
                }
                resultlista.Add(new PROCESS
                {
                    ID = pro.ID,
                    Nombre = pro.Nombre,
                    CPU = pro.CPU,
                    Prioridad = pro.Prioridad,
                    TiLLegada = pro.TiLLegada,
                    Estado = pro.Estado,
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
            PROCESS pro = null;
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
                pro = lista[lista.Count - 1];

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
                        lista[pos].CPU = (lista[pos].CPU - quantum);

                        pro.CPU = lista[pos].CPU = (lista[pos].CPU - quantum);
                        resultlista.Add(new PROCESS
                        {

                            Nombre = pro.Nombre,

                            Prioridad = pro.Prioridad,
                            TiLLegada = pro.TiLLegada,
                            Estado = pro.Estado,
                        });
                        if (lista[pos].CPU > quantum)
                        {
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
                        lista[pos].CPU = 0;
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
                    lista[pos].CPU = (lista[pos].CPU - quantum);
                    if (lista[pos].CPU > quantum)
                    {
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
                    lista[pos].CPU = 0;
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
            PROCESS pro = null;
            while (!finIteraciones)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].TiLLegada == tiempoGlobal)
                    {
                        Console.WriteLine("Insertando proceso: " + lista[i].Nombre + " tiempo " + tiempoGlobal);
                        tempLista.Add(lista[i]);
                        lista.RemoveAt(i);
                    }
                }
                //pro = lista[lista.Count - 1];

                if (contadorQ == tempLista[0].CPU)
                {
                    Console.WriteLine("Proceso terminado: " + tempLista[0].Nombre + " tiempo: " + tiempoGlobal);

                    pro = tempLista[0];
                    pro.Estado = "Terminado";
                    pro.TiLLegada = tiempoGlobal;
                    resultlista.Add(new PROCESS
                    {
                        ID = pro.ID,
                        Nombre = pro.Nombre,
                        CPU = pro.CPU,
                        Prioridad = pro.Prioridad,
                        TiLLegada = pro.TiLLegada,
                        Estado = pro.Estado,
                    });


                    tempLista.RemoveAt(0);
                    contadorQ = 0;


                }
                else if (contadorQ - quantum == 0)
                {
                    Console.WriteLine("Ejecutando CPU proceso: " + tempLista[0].Nombre + " tiempo: " + tiempoGlobal);
                    pro.Estado = "Ejecucion";
                    tempLista[0].CPU = (tempLista[0].CPU - quantum);
                    pro.CPU = tempLista[0].CPU;
                    Console.WriteLine("CPU restante: " + tempLista[0].CPU);
                    pro = tempLista[0];
                    pro.TiLLegada = tiempoGlobal;
                    if (tempLista[0].CPU > quantum && tempLista[0].CPU != 0)
                    {
                        Console.WriteLine("El proceso pasa a bloqueado");
                        pro.Estado = "Bloqueado";
                        resultlista.Add(new PROCESS
                        {
                            ID = pro.ID,
                            Nombre = pro.Nombre,
                            CPU = pro.CPU,
                            Prioridad = pro.Prioridad,
                            TiLLegada = pro.TiLLegada,
                            Estado = pro.Estado,
                        });
                    }

                    else if (tempLista[0].CPU != 0)
                    {
                        Console.WriteLine("El proceso pasa a listo");
                        pro.Estado = "Listo";
                        resultlista.Add(new PROCESS
                        {
                            ID = pro.ID,
                            Nombre = pro.Nombre,
                            CPU = pro.CPU,
                            Prioridad = pro.Prioridad,
                            TiLLegada = pro.TiLLegada,
                            Estado = pro.Estado,
                        });
                    }

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
                    else if (lista[i].CPU < compararCPU && lista[i].TiLLegada <= tiempoGlobal)
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
                    pro.TiLLegada = tiempoGlobal;
                    //pro.CPU=
                    Console.WriteLine("Termina en T: " + tiempoGlobal);

                    lista.RemoveAt(posProceso);
                    resultlista.Add(new PROCESS
                    {

                        Nombre = pro.Nombre,
                        CPU = pro.CPU,
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
        internal void PlanifGarantizada(int Quantum)
        {
            //Solo toma en cuenta la rafaga de CPU y la instancia de llegada
            int tiempoGlobal = 0;
            double quantum = (double)Quantum, recibeQuantum = 0.00, n = 0; //En donde n es la cantidad de procesos
            bool finIteraciones = false;

            PROCESS pro = null;


            //Algoritmo de burbuja para ordenarlos por instancia de llegada
            for (int j = 0; j <= lista.Count - 2; j++)
            {
                for (int i = 0; i <= lista.Count - 2; i++)
                {
                    if (lista[i].TiLLegada > lista[i + 1].TiLLegada)
                    {
                        PROCESS temp = lista[i + 1];
                        lista[i + 1] = lista[i];
                        lista[i] = temp;
                    }
                }
            }
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].AlgoCPU = (double)lista[i].CPU;
            }
            while (!finIteraciones)
            {
                pro = lista[lista.Count - 1];
                n = 0.00;

                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].TiLLegada <= tiempoGlobal && lista[i].AlgoCPU > 0)
                    {
                        //Console.WriteLine("Evaluando proceso " + lista[i].getNombre());
                        n++;
                    }
                }

                Console.WriteLine("Cantidad de procesos: " + n + " tiempo: " + tiempoGlobal);
                recibeQuantum = ((1 / n) * quantum);

                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].TiLLegada <= tiempoGlobal && lista[i].AlgoCPU > 0)
                    {
                        if (lista[i].AlgoCPU > recibeQuantum)
                        {
                            Console.WriteLine("Proceso: " + lista[i].Nombre);

                            lista[i].AlgoCPU = (lista[i].AlgoCPU - recibeQuantum);
                            //pro.AlgoCPU = lista[i].AlgoCPU = (lista[i].AlgoCPU - recibeQuantum);
                            Console.WriteLine("Se le resto: " + recibeQuantum + " quantum restante: " + lista[i].AlgoCPU);
                            pro = lista[i];
                            pro.Estado = "Ejecucion";
                            resultlista.Add(new PROCESS
                            {

                                Nombre = pro.Nombre,
                                AlgoCPU = pro.AlgoCPU,
                                Prioridad = pro.Prioridad,
                                TiLLegada = pro.TiLLegada,
                                Estado = pro.Estado,
                            });
                        }
                        else
                        {
                            Console.WriteLine("Proceso terminado: " + lista[i].Nombre);

                            lista[i].AlgoCPU = 0;
                            pro = lista[i];

                            pro.Estado = "Terminado";
                            resultlista.Add(new PROCESS
                            {

                                Nombre = pro.Nombre,
                                AlgoCPU = pro.AlgoCPU,
                                Prioridad = pro.Prioridad,
                                TiLLegada = pro.TiLLegada,
                                Estado = pro.Estado,
                            });

                        }
                    }

                }


                finIteraciones = true;

                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].AlgoCPU > 0)
                        finIteraciones = false;
                }

                tiempoGlobal++;
            }

        }

        internal void AlgorPorLoteria(int Quantum)
        {
            int quantum = Quantum;
            double ticket = 10, sumPrioridad, porcentaje, loteria ;
            Random random = new Random();
            bool procesoTerminado, finIteraciones = false;
            PROCESS pro = null;
            while (!finIteraciones)
            {
                sumPrioridad = 1;
                porcentaje = 100;
                finIteraciones = false;
                procesoTerminado = false;

                for (int i = 0; i < lista.Count; i++)
                {
                    sumPrioridad += (int)lista[i].Prioridad;
                }
                Console.WriteLine("SumPrioridad " + sumPrioridad);

                porcentaje /= sumPrioridad;
                Console.WriteLine("Porcentaje: " + porcentaje);

                for (int i = 0; i < lista.Count; i++)
                {
                    lista[i].probabilidad=(porcentaje * (double)lista[i].Prioridad);
                    if (i == 0)
                        lista[i].Ticket=(lista[i].probabilidad / ticket);
                    else
                        lista[i].Ticket=(lista[i - 1].Ticket + lista[i].probabilidad / ticket);
                }
                Console.WriteLine("Num ticket para ultimo proceso: " + lista[lista.Count - 1].Ticket); //-> lista[lista.Count-1].getTicket()

                while (!procesoTerminado)
                {
                    loteria = random.Next(0, Convert.ToInt32(lista[lista.Count - 1].Ticket));
                    Console.WriteLine("Loteria: " + loteria);

                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (loteria <= lista[i].Ticket)
                        {
                            if (lista[i].CPU < quantum)
                                lista[i].CPU=0;
                            else {
                                lista[i].CPU = (lista[i].CPU - quantum);
                                Console.WriteLine("Se resto CPU a proceso: " + lista[i].Nombre + " - " + lista[i].CPU);
                                pro = lista[i];
                                pro.Estado = "Ejecucion";

                                resultlista.Add(new PROCESS
                                {
                                    ID = pro.ID,
                                    Nombre = pro.Nombre,
                                    CPU = pro.CPU,
                                    Prioridad = pro.Prioridad,
                                    TiLLegada = pro.TiLLegada,
                                    Estado = pro.Estado,
                                });
                            }
                                
                            if (lista[i].CPU > quantum && lista[i].CPU != 0) {

                                Console.WriteLine("El proceso pasa a bloqueado");
                                pro = lista[i];
                                pro.Estado = "Bloqueado";
                                resultlista.Add(new PROCESS
                                {
                                    ID = pro.ID,
                                    Nombre = pro.Nombre,
                                    CPU = pro.CPU,
                                    Prioridad = pro.Prioridad,
                                    TiLLegada = pro.TiLLegada,
                                    Estado = pro.Estado,
                                });

                            }
                                
                            else if (lista[i].CPU != 0)
                            {
                                Console.WriteLine("El proceso pasa a listo");
                                pro = lista[i];
                                pro.Estado = "Listo";

                                resultlista.Add(new PROCESS
                                {
                                    ID = pro.ID,
                                    Nombre = pro.Nombre,
                                    CPU = pro.CPU,
                                    Prioridad = pro.Prioridad,
                                    TiLLegada = pro.TiLLegada,
                                    Estado = pro.Estado,
                                });
                            }
                              

                            if (lista[i].CPU == 0)
                            {
                                Console.WriteLine("El proceso " + lista[i].Nombre + " se ha terminado");
                                pro = lista[i];
                                pro.Estado = "Terminado";

                                lista.RemoveAt(i);
                                procesoTerminado = true;

                                resultlista.Add(new PROCESS
                                {
                                    ID = pro.ID,
                                    Nombre = pro.Nombre,
                                    CPU = pro.CPU,
                                    Prioridad = pro.Prioridad,
                                    TiLLegada = pro.TiLLegada,
                                    Estado = pro.Estado,
                                });
                            }
                            break;
                        }
                    }
                }

                if (lista.Count == 0)
                    finIteraciones = true;

            }
        }
        internal void ColasMultiples(int Quantum)
        {
            // hay que llenar listas por prioridades, solo busca cual es la prioridad mayor para saber cuantas listas debe hacer.
            int PrioridadColas = 0;
            foreach (PROCESS  i in lista)
            {
                if (PrioridadColas < i.Prioridad)
                {
                    PrioridadColas = (int)i.Prioridad;
                    //Console.WriteLine(PrioridadColas);
                }

            }
            //  Console.WriteLine(PrioridadColas);

            while (PrioridadColas > 0)
            {

                List<PROCESS> tempLista = new List<PROCESS>();
                foreach (PROCESS i in lista)
                {
                    if (i.Prioridad == PrioridadColas)
                    {
                        tempLista.Add(i);
                    }
                }
                Console.WriteLine("Cola " + PrioridadColas);

                if (tempLista.Count != 0)
                {
                     //Prioridad(tempLista,Quantum);
                    /*foreach(Proceso i in tempLista)
                    {
                        Console.WriteLine (i.getNombre());
                    }*/
                }
                else
                {
                    Console.WriteLine("No hay nada en lista" + PrioridadColas);
                };

                PrioridadColas--;
                //Console.WriteLine(PrioridadColas+1);
                tempLista.Clear();
            }
        }
        internal void RR(List<PROCESS> ListaMC,int Quantum)
        {
            int quantum = Quantum, tiempoGlobal = 0, contadorQ = 0; //contadorQuantum
            bool finIteraciones = false;
            List<PROCESS> tempLista = new List<PROCESS>();

            while (!finIteraciones)
            {
                for (int i = 0; i < ListaMC.Count; i++)
                {
                    if (ListaMC[i].TiLLegada == tiempoGlobal)
                    {
                        Console.WriteLine("Insertando proceso: " + ListaMC[i].Nombre + " tiempo " + tiempoGlobal);//tiene que ser diferente tiempo de llegada si no se salta uno
                        tempLista.Add(ListaMC[i]);
                        ListaMC.RemoveAt(i);
                    }
                }
                foreach (var item in ListaMC)
                {
                    Console.WriteLine(""+ item.Nombre); 
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
        private void Prioridad_I_CPU()
        {
            int tiempoGlobal = 0;
            bool finIteraciones = false;
            List<PROCESS> tempLista = new List<PROCESS>();

            foreach (PROCESS proceso in lista)
                tempLista.Add(new PROCESS(proceso.ID, proceso.Nombre, proceso.CPU, proceso.Prioridad, proceso.TiLLegada, proceso.Estado, proceso.AlgoCPU, proceso.probabilidad, proceso.Ticket));

            for (int j = 0; j <= tempLista.Count - 2; j++)
            {
                for (int i = 0; i <= tempLista.Count - 2; i++)
                {
                    if (tempLista[i].Prioridad > tempLista[i + 1].Prioridad)
                    {
                        PROCESS temp = tempLista[i + 1];
                        tempLista[i + 1] = tempLista[i];
                        tempLista[i] = temp;
                    }
                }
            }

            PROCESS pro = tempLista[tempLista.Count - 1];

            while (!finIteraciones)
            {
                for (int i = tempLista.Count - 1; i >= 0; i--)
                {
                    if (tempLista[i].Prioridad <= pro.Prioridad && tempLista[i].TiLLegada <= tiempoGlobal)
                        pro = tempLista[i];
                }

                pro.CPU = pro.CPU - 1;
                Console.WriteLine("Proceso: " + pro.Nombre + " CPU: " + pro.CPU);

                if (pro.CPU == 0)
                {
                    Console.WriteLine("Ejecucion" +pro.Nombre);
                    Console.WriteLine("Terminado "+ pro.Nombre);
                    tempLista.Remove(pro);

                    if (tempLista.Count != 0)
                        pro = tempLista[tempLista.Count - 1];
                }
                else
                {
                    Console.WriteLine("Ejecucion" + pro.Nombre);
                    Console.WriteLine("Listo" + pro.Nombre);
                }
                tiempoGlobal++;

                finIteraciones = true;

                if (tempLista.Count != 0)
                    finIteraciones = false;
            }
        }






    }







    }

