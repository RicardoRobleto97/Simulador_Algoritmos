using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Algoritmos
{
    public partial class Paginaciones : Form
    {
        public static List<PROCESS> lista = new List<PROCESS>();
        public static List<PROCESS> resultlista = new List<PROCESS>();
        public static List<Referencia> listareferencia = new List<Referencia>();
        List<Referencia> tempLista = new List<Referencia>();
        List<string[]> datosFilas = new List<string[]>();
        Form1 form1;

        Conexion con = new Conexion();
        Algoritmos algors = new Algoritmos();
        int paginacion;
        int marcos;
        int Quantum;
        private void algoritmos() {

            switch (paginacion)
            {
                case 1:
                    FIFO();
                    break;
                case 2:
                    Optimo();
                    break;
                case 3:
                    NRU();
                    break;
                case 4:
                    SegundasOportunidades();
                    break;
                case 5:
                    Clock();
                    break;
               
            }

        }

        private void Clock()
        {
            int posListaR = 0, tiempo = 0, clockMarco = 1;
            MarcoReferencia[] marcosReferencias = new MarcoReferencia[marcos];

            for (int i = 0; i < marcos; i++)
            {
                marcosReferencias[i] = new MarcoReferencia();
            }

            foreach (Referencia refs in listareferencia)
                tempLista.Add(new Referencia(refs.Id, refs.nombre));

            while (posListaR != tempLista.Count)
            {
                bool vacio_Repetido = false; //

                //Evaluamos si hay marcos vacios y si no esta repetido
                for (int i = 0; i < marcosReferencias.Length; i++)
                {
                    //Referencias ya dentro de uno de los marcos
                    if (marcosReferencias[i].getOcupadoPor().Equals(tempLista[posListaR].nombre))
                    {
                        tempLista[posListaR].marco = i;
                        marcosReferencias[i].permanecer = true;
                        vacio_Repetido = true;
                        break;
                    }
                    //marcos de referencias si estan vacios
                    else if (marcosReferencias[i].vacio)
                    {
                        marcosReferencias[i].setOcupadoPor(tempLista[posListaR].nombre, tiempo);
                        marcosReferencias[i].vacio = false;
                        marcosReferencias[i].permanecer = true;
                        tempLista[posListaR].marco = i;
                        tempLista[posListaR].fallo = true;
                        vacio_Repetido = true;
                        break;
                    }
                }


                if (!vacio_Repetido)
                {

                    int posSacar = -1;

                    //Evaluamos si hay marcos inactivos
                    for (int i = 0; i < marcosReferencias.Length; i++)
                    {
                        if (!marcosReferencias[i].permanecer)
                        {
                            if (posSacar == -1)
                                posSacar = i;
                            else if (marcosReferencias[i].tiempo < marcosReferencias[posSacar].tiempo)
                                posSacar = clockMarco;
                        }
                    }

                    if (posSacar == -1) //Si no hay marcos inactivos entramos en este bloque
                    {
                        posSacar = 0;

                        for (int i = 0; i < marcosReferencias.Length; i++)
                        {
                            //Console.WriteLine(marcosReferencias[i].getOcupadoPor() + " - " + marcosReferencias[posSacar].getOcupadoPor());
                            if (marcosReferencias[i].tiempo < marcosReferencias[posSacar].tiempo)
                                posSacar = i;
                        }
                    }

                    for (int i = 0; i < marcosReferencias.Length; i++)
                        marcosReferencias[i].permanecer = false;

                    //Asignar los marcos y referencias
                    tempLista[posListaR].marco = posSacar;
                    tempLista[posListaR].fallo = true;
                    marcosReferencias[posSacar].setOcupadoPor(tempLista[posListaR].nombre, tiempo);
                    marcosReferencias[posSacar].permanecer = true;
                }
                if (clockMarco == marcosReferencias.Length + 1)
                {
                    clockMarco = 1;
                }
                clockMarco++;
                posListaR++;
                tiempo++;
            }
        }

        private void SegundasOportunidades()
        {
            int posListaR = 0, tiempo = 0;
            MarcoReferencia[] marcosReferencias = new MarcoReferencia[marcos];

            for (int i = 0; i < marcos; i++)
            {
                marcosReferencias[i] = new MarcoReferencia();
            }

            foreach (Referencia refs in listareferencia)
                tempLista.Add(new Referencia(refs.Id, refs.nombre));

            while (posListaR != tempLista.Count)
            {
                bool vacio_Repetido = false; //

                //Evaluamos si hay marcos vacios y si no esta repetido
                for (int i = 0; i < marcosReferencias.Length; i++)
                {
                    //Referencias ya dentro de uno de los marcos
                    if (marcosReferencias[i].getOcupadoPor().Equals(tempLista[posListaR].nombre))
                    {
                        tempLista[posListaR].marco = i;
                        marcosReferencias[i].permanecer = true;
                        vacio_Repetido = true;
                        break;
                    }
                    //marcos de referencias si estan vacios
                    else if (marcosReferencias[i].vacio)
                    {
                        marcosReferencias[i].setOcupadoPor(tempLista[posListaR].nombre, tiempo);
                        marcosReferencias[i].vacio = false;
                        marcosReferencias[i].permanecer = true;
                        tempLista[posListaR].marco = i;
                        tempLista[posListaR].fallo = true;
                        vacio_Repetido = true;
                        break;
                    }
                }

                if (!vacio_Repetido)
                {

                    int posSacar = -1;

                    //Evaluamos si hay marcos inactivos
                    for (int i = 0; i < marcosReferencias.Length; i++)
                    {
                        if (!marcosReferencias[i].permanecer)
                        {
                            if (posSacar == -1)
                                posSacar = i;
                            else if (marcosReferencias[i].tiempo < marcosReferencias[posSacar].tiempo)
                                posSacar = i;
                        }
                    }

                    if (posSacar == -1) //Si no hay marcos inactivos entramos en este bloque
                    {
                        posSacar = 0;

                        for (int i = 0; i < marcosReferencias.Length; i++)
                        {
                            //Console.WriteLine(marcosReferencias[i].getOcupadoPor() + " - " + marcosReferencias[posSacar].getOcupadoPor());
                            if (marcosReferencias[i].tiempo < marcosReferencias[posSacar].tiempo)
                                posSacar = i;
                        }
                    }

                    for (int i = 0; i < marcosReferencias.Length; i++)
                        marcosReferencias[i].permanecer = false;

                    //Asignar los marcos y referencias
                    tempLista[posListaR].marco = posSacar;
                    tempLista[posListaR].fallo = true;
                    marcosReferencias[posSacar].setOcupadoPor(tempLista[posListaR].nombre, tiempo);
                    marcosReferencias[posSacar].permanecer = true;
                }

                posListaR++;
                tiempo++;
            }
        }

        private void NRU()
        {
            int posListaR = 0, tiempo = 0;
            MarcoReferencia[] marcosReferencias = new MarcoReferencia[marcos];

            for (int i = 0; i < marcos; i++)
            {
                marcosReferencias[i] = new MarcoReferencia();
            }

            foreach (Referencia refs in listareferencia)
                tempLista.Add(new Referencia(refs.Id, refs.nombre));

            while (posListaR != tempLista.Count)
            {
                bool vacio_Repetido = false; //
                //Evaluamos si hay marcos vacios y si no esta repetido
                for (int i = 0; i < marcosReferencias.Length; i++)
                {
                    //Referencias ya dentro de uno de los marcos
                    if (marcosReferencias[i].getOcupadoPor().Equals(tempLista[posListaR].nombre))
                    {
                        tempLista[posListaR].marco = i;
                        vacio_Repetido = true;
                        break;
                    }
                    //marcos de referencias si estan vacios
                    else if (marcosReferencias[i].vacio)
                    {
                        marcosReferencias[i].setOcupadoPor(tempLista[posListaR].nombre, tiempo);
                        tempLista[posListaR].marco = i;
                        marcosReferencias[i].vacio = false;
                        tempLista[posListaR].fallo = true;
                        vacio_Repetido = true;
                        break;
                    }
                }

                if (!vacio_Repetido)
                {
                    int contMarcosTemp = marcosReferencias.Length, posSacar = 0;

                    for (int i = posListaR - 1; i >= 0; i--)
                    {
                        for (int x = 0; x < marcosReferencias.Length; x++)
                        {
                            if (marcosReferencias[x].getOcupadoPor().Equals(tempLista[i].nombre) &&
                                !marcosReferencias[x].yaEvaluado && contMarcosTemp != 0)
                            {
                                posSacar = x;
                                marcosReferencias[x].yaEvaluado = true;
                                contMarcosTemp--;
                                break;
                            }
                            if (contMarcosTemp == 0)
                                break;
                        }
                    }

                    tempLista[posListaR].marco = posSacar;
                    tempLista[posListaR].fallo = true;
                    marcosReferencias[posSacar].setOcupadoPor(tempLista[posListaR].nombre, tiempo);

                    //Resetear yaEvaluado
                    for (int i = 0; i < marcosReferencias.Length; i++)
                        marcosReferencias[i].yaEvaluado = false;
                }

                posListaR++;
                tiempo++;
            }
        }

        private void Optimo()
        {
            /*  Evaluamos si la referencia ya ocupa un marco
                Si no ocupa un marco evaluamos si hay un marco vacio
                Si no hay marcos vacios, evaluamos las referencias futuras y 
                    las comparamos con aquellas referencias que ya ocupan un marco
                Evaluamos las que se repitan y aplicamos fifo en las que no se repitan
                Si todos se repiten aplicamos "FIFO inverso" es decir sacamos aquella 
                    referencia 'repetida' (que se encuentra en el marco) que tardara mas 
                    tiempo en volver a ocupar un marco */
            int posListaR = 0, tiempo = 0;
            MarcoReferencia[] marcosReferencias = new MarcoReferencia[marcos];

            for (int i = 0; i < marcos; i++)
            {
                marcosReferencias[i] = new MarcoReferencia();
            }

            foreach (Referencia refs in listareferencia)
                tempLista.Add(new Referencia(refs.Id, refs.nombre));

            while (posListaR != tempLista.Count)
            {
                bool vacio_Repetido = false; //
                //Evaluamos si hay marcos vacios y si no esta repetido
                for (int i = 0; i < marcosReferencias.Length; i++)
                {
                    //Referencias ya dentro de uno de los marcos
                    if (marcosReferencias[i].getOcupadoPor().Equals(tempLista[posListaR].nombre))
                    {
                        tempLista[posListaR].marco = i;
                        vacio_Repetido = true;
                        break;
                    }
                    //Marcos de referencias si estan vacios
                    else if (marcosReferencias[i].vacio)
                    {
                        marcosReferencias[i].setOcupadoPor(tempLista[posListaR].nombre, tiempo);
                        tempLista[posListaR].marco = i;
                        marcosReferencias[i].vacio = false;
                        tempLista[posListaR].fallo = true;
                        vacio_Repetido = true;
                        break;
                    }
                }

                if (!vacio_Repetido)
                {
                    //Evaluamos las referencias futuras si estas se repiten y si ocupan un marco en el futuro
                    for (int i = posListaR; i < tempLista.Count; i++)
                    {
                        for (int x = 0; x < marcosReferencias.Length; x++)
                        {
                            if (tempLista[i].nombre.Equals(marcosReferencias[x].getOcupadoPor()))
                                marcosReferencias[x].permanecer = true;
                        }
                    }

                    int posSacar = -1;

                    //De las referencias que no se repiten sacamos el mas antiguo (FIFO)
                    for (int x = 0; x < marcosReferencias.Length; x++)
                    {
                        if (!marcosReferencias[x].permanecer)
                        {
                            if (posSacar == -1) //Solo se entra en este bloque en el primer marco.permanecer == false
                                posSacar = x;
                            else if (marcosReferencias[x].tiempo < marcosReferencias[posSacar].tiempo)
                                posSacar = x;
                        }
                    }

                    //Console.WriteLine("PosSacar: " + posSacar);

                    //Si posSacar queda igual a -1 implica que todas las referencias volveran a ocupar un marco
                    if (posSacar == -1) //Sacamos la referencia que va a tardar mas tiempo en volver a ocuparse
                    {
                        int contMarcosTemp = marcosReferencias.Length;

                        for (int i = posListaR; i < tempLista.Count; i++)
                        {
                            for (int x = 0; x < marcosReferencias.Length; x++)
                            {
                                if (marcosReferencias[x].getOcupadoPor().Equals(tempLista[i].nombre)
                                    && !marcosReferencias[x].yaEvaluado && contMarcosTemp != 0)
                                {
                                    posSacar = x;
                                    marcosReferencias[x].yaEvaluado = true;
                                    contMarcosTemp--;
                                    break;
                                }
                            }
                            if (contMarcosTemp == 0)
                                break;
                        }
                    }

                    tempLista[posListaR].marco = posSacar;
                    tempLista[posListaR].fallo = true;
                    marcosReferencias[posSacar].setOcupadoPor(tempLista[posListaR].nombre, tiempo);

                    //Resetear permanecer y yaEvaluado
                    for (int i = 0; i < marcosReferencias.Length; i++)
                    {
                        marcosReferencias[i].permanecer = false;
                        marcosReferencias[i].yaEvaluado = false;
                    }
                }

                posListaR++;
                tiempo++;
            }
        }

        private void FIFO()
        {
            /*  1. Evaluamos si la referencia ya esta dentro del marco 
                    (Puede darse el caso en donde hayan marcos vacios pero la referencia este repetida)
                2. Evaluamos si hay marcos vacios
                3. Si esta vacio lo metemos en esa posicion
                4. Si no esta vacio evaluamos si la referencia ya esta dentro del marco
                5. Si ya esta dentro del marco lo dejamos en esa posicion
                6. Si no esta dentro del marco evaluamos el proceso mas antiguo
                7. Se saca el proceso mas antiguo y se coloca en esa posicion   */

            int posListaR = 0, tiempo = 0;
            MarcoReferencia[] marcosReferencias = new MarcoReferencia[marcos];

            for (int i = 0; i < marcos; i++)
            {
                marcosReferencias[i] = new MarcoReferencia();
            }

            foreach (Referencia refs in listareferencia)
                tempLista.Add(new Referencia(refs.Id, refs.nombre));
            foreach (var item in tempLista)
            {
                Console.WriteLine("->"+item.nombre);
            }
            while (posListaR != tempLista.Count)
            {
                bool vacio_Repetido = false; //
                //Evaluamos si hay marcos vacios y si no esta repetido
                for (int i = 0; i < marcosReferencias.Length; i++)
                {
                    //Referencias ya dentro de uno de los marcos
                    if (marcosReferencias[i].getOcupadoPor().Equals(tempLista[posListaR].nombre))
                    {
                        tempLista[posListaR].marco = i;
                        vacio_Repetido = true;
                        break;
                    }
                    //marcos de referencias si estan vacios
                    else if (marcosReferencias[i].vacio)
                    {
                        marcosReferencias[i].setOcupadoPor(tempLista[posListaR].nombre, tiempo);
                        tempLista[posListaR].marco = i;
                        marcosReferencias[i].vacio = false;
                        tempLista[posListaR].fallo = true;
                        vacio_Repetido = true;
                        break;
                    }
                }

                //Al llegar aqui implica que la referencia que se esta evaluando no esta repetida y tampoco hay espacio
                if (!vacio_Repetido)
                {
                    int refMasAntiguo = 0;

                    for (int i = 0; i < marcosReferencias.Length; i++)
                        if (marcosReferencias[i].tiempo < marcosReferencias[refMasAntiguo].tiempo)
                        {
                            refMasAntiguo = i;
                            break;
                        }

                    marcosReferencias[refMasAntiguo].setOcupadoPor(tempLista[posListaR].nombre, tiempo);
                    tempLista[posListaR].marco = refMasAntiguo;
                    tempLista[posListaR].fallo = true;
                }

                posListaR++;
                tiempo++;
            }

            /*foreach (Referencia item in tempLista)
            {
                Console.WriteLine(item.nombre + " - " + item.marco);
            }*/
        }

        public Paginaciones(int paginacion,int marco,int Quantum)
        {
            InitializeComponent();
            this.marcos = marco;
            this.paginacion = paginacion;
            Cargar(Quantum);
            CrearReferencias();
            algoritmos();
            CrearFilas();
        }

        private void CrearFilas()
        {
            for (int i = 0; i < marcos; i++)
            {
                string[] nuevoArreglo = new string[tempLista.Count];

                for (int x = 0; x < tempLista.Count; x++)
                    nuevoArreglo[x] = " - ";

                for (int x = 0; x < tempLista.Count; x++)
                    if (tempLista[x].marco == i)
                    {
                        //Console.WriteLine("Agregando: " + tempLista[x].nombre);
                        nuevoArreglo[x] = tempLista[x].nombre;
                    }


                datosFilas.Add(nuevoArreglo);
            }

            /*for (int i = 0; i < datosFilas.Count; i++)
            {
                mostrarArreglo(datosFilas[i]);
            }*/

            //Creamos las columnas
            for (int i = 0; i < tempLista.Count; i++)
            {
                dataGridView1.Columns.Add(tempLista[i].nombre, tempLista[i].nombre);
                //dataGridView1.Columns[i].Visible = false; //seteamos las columnas como "no visibles"
            }

            //Insertamos las filas para las columnas
            for (int i = 0; i < datosFilas.Count; i++)
            {
                dataGridView1.Rows.Add(datosFilas[i]);
            }
            double fallos=0.00;
            for(int i = 0; i < tempLista.Count; i++)
            {
                if (tempLista[i].fallo == true)
                {
                    fallos++;
                }
            }

            this.textBox1.Text = fallos.ToString();
            this.textBox2.Text = tempLista.Count.ToString();
            this.textBox3.Text = Math.Round((fallos / tempLista.Count),2).ToString();
            this.textBox4.Text = Math.Round((1 - fallos / tempLista.Count),2).ToString();


        }

        private void Paginaciones_Load(object sender, EventArgs e)
        {
           
        }
        private void Cargar(int Quantum)
        {
            algors.Prioridad(Quantum);
            dgvPaginacion.DataSource = algors.GetLista();
        }
        private void CrearReferencias()
        {
            foreach (var item in algors.GetLista())
            {
                if (item.Estado.Equals("Ejecucion"))
                {
                    Console.WriteLine(item.Nombre);
                    listareferencia.Add(new Referencia
                    (   item.ID,
                        item.Nombre
                    ));
                }
            }
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
                    pro.Estado = "Ejecucion";
                    pro.CPU = (pro.CPU - quantum);
                    resultlista.Add(new PROCESS
                    {
                        ID = pro.ID,
                        Nombre = pro.Nombre,
                        CPU = pro.CPU,
                        Prioridad = pro.Prioridad,
                        TiLLegada = pro.TiLLegada,
                        Estado = pro.Estado,
                    });
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

        public class Referencia
        {
            public int Id { get; set; }
            public string nombre { get; set; }

            //Marco es la posicion al marco de referencia en donde se asigna la referencia
            public int marco { get; set; }

            public bool fallo { get; set; }

            public Referencia(int Id, string nombre)
            {
                this.Id = Id;
                this.nombre = nombre;
                marco = -1;
                fallo = false;
            }

        }

        public class MarcoReferencia
        {
            public bool vacio { get; set; }
            private string ocupadoPor;
            public int tiempo; //Se utiliza para determinar aquel proceso mas viejo
            public bool permanecer { get; set; } //Determinamos si la referencia ocupada en el marco, permanece en el mismo
            public bool yaEvaluado { get; set; }


            public MarcoReferencia()
            {
                vacio = true;
                ocupadoPor = "-";
                permanecer = false; //false = que no permanece
                yaEvaluado = false;
            }

            public void setOcupadoPor(string referencia, int tiempo)
            {
                if (ocupadoPor == null)
                {
                    ocupadoPor = referencia;
                    this.tiempo = tiempo;
                }
                else if (ocupadoPor.Equals(referencia))
                {
                    ocupadoPor = referencia;
                }
                else
                {
                    ocupadoPor = referencia;
                    this.tiempo = tiempo;
                }
            }

            public string getOcupadoPor()
            {
                return ocupadoPor;
            }
        }
    }
}
