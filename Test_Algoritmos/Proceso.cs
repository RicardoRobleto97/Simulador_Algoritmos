using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Algoritmos
{
    internal class Proceso
    {
        private string nombre;
        private int CPU;
        private int Prioridad;
        private int ILlegada; //Instancia de llegada
                              //private bool listo_bloqeado;
        private bool agregado;  //Se utiliza en RoundRobin
        private double Probabilidad; //Se utiliza en algorPorLoteria
        private int Ticket; //Se utiliza en algorPorLoteria
        private double AlgoPlaniCPU; //Es lo mismo que CPU, solamente que utilizamos un double para el algoritmo de planificacion

        public Proceso(string nombre, int CPU, int Prioridad, int ILlegada)
        {
            this.nombre = nombre;
            this.CPU = CPU;
            this.Prioridad = Prioridad;
            this.ILlegada = ILlegada;
            // this.listo_bloqeado = false; //Cuando esta en false implica que esta en listo, true es bloqueado
            AlgoPlaniCPU = 0.00;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setPrioridad(int Prioridad)
        {
            this.Prioridad = Prioridad;
        }

        public int getPrioridad()
        {
            return this.Prioridad;
        }

        public void setILlegada(int ILlegada)
        {
            this.ILlegada = ILlegada;
        }

        public int getILlegada()
        {
            return this.ILlegada;
        }

        public void setCPU(int CPU)
        {
            this.CPU = CPU;
        }

        public int getCPU()
        {
            return this.CPU;
        }

        public void setAgregado(bool agregado)
        {
            this.agregado = agregado;
        }

        public bool getAgregado()
        {
            return this.agregado;
        }

        public void setProbabilidad(double Probabilidad)
        {
            this.Probabilidad = Probabilidad;
        }

        public double getProbabilidad()
        {
            return this.Probabilidad;
        }

        public void setTicket(int Ticket)
        {
            this.Ticket = Ticket;
        }

        public int getTicket()
        {
            return this.Ticket;
        }

        public void setAlgoPlaniCPU(double AlgoPlaniCPU)
        {
            this.AlgoPlaniCPU = AlgoPlaniCPU;
        }
        public double getAlgoPlaniCPU()
        {
            return this.AlgoPlaniCPU;
        }


    }
}
