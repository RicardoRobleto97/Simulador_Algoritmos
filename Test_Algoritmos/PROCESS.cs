//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test_Algoritmos
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROCESS
    {
        public PROCESS()
        {
            this.Estado = "Esperando";
            this.Nombre = " ";
            this.CPU = 0;
            this.AlgoCPU = 0.00;
        }
        public PROCESS( string nombre, int? cPU, int? tiLLegada, int? prioridad)
        {
      
            Nombre = nombre;
            CPU = cPU;
            TiLLegada = tiLLegada;
            Prioridad = prioridad;
           
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> CPU { get; set; }
        public Nullable<int> TiLLegada { get; set; }
        public Nullable<int> Prioridad { get; set; }
        public string Estado { get; set; }
        public double AlgoCPU { get; set; }
        public double probabilidad { get; set; }
        public double Ticket { get; set; }
    }

}
