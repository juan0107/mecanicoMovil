using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AutoTunning
{
    internal class Automovil
    {
        private int kilometraje;
        private int consumo;
        private string aspiracion;
        private int potencia;
        private int Torque;
        private string Transmision;
        private string Embrage;
        private string Liquido;
        private string escape;
        private string Ecu;
        private string Suspension;
        private int Valor;
        private string Frenos;
        private string Traccion;
        private string Marca;
        private string Modelo;
        private string modeloMotor;
        private string Freno;
        private int v1;
        private int v2;
        private string v3;
        private int v4;
        private int v5;
        private string v6;
        private string v7;
        private string v8;
        private string v9;
        private string v10;
        private string v11;
        private string v12;
        private string v13;
        private string v14;
        private string v15;
        private string v16;
        private string v17;
        private string v18;

        public Automovil(int kilometraje, int consumo, string aspiracion, int potencia, int torque, string transmision, string embrage, string liquido, string escape, string ecu, string suspension, int valor, string frenos, string traccion, string marca, string modelo, string modeloMotor, string freno)
        {
            this.Kilometraje = kilometraje;
            this.consumo = consumo;
            this.aspiracion = aspiracion;
            this.potencia = potencia;
            this.Torque = torque;
            this.Transmision = transmision;
            this.Embrage = embrage;
            this.Liquido = liquido;
            this.Escape = escape;
            this.Ecu1 = ecu;
            this.Suspension = suspension;
            this.Valor = valor;
            this.Frenos = frenos;
            this.Traccion = traccion;
            this.Marca = marca;
            this.Modelo = modelo;
            this.ModeloMotor = modeloMotor;
            this.Freno = freno;
        }

        public Automovil(int v1, int v2, string v3, int v4, int v5, string v6, string v7, string v8, string v9, string v10, string v11, string v12, string v13, string v14, string v15, string v16, string v17, string v18)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
            this.v8 = v8;
            this.v9 = v9;
            this.v10 = v10;
            this.v11 = v11;
            this.v12 = v12;
            this.v13 = v13;
            this.v14 = v14;
            this.v15 = v15;
            this.v16 = v16;
            this.v17 = v17;
            this.v18 = v18;
        }

        public int Kilometraje { get => kilometraje; set => kilometraje = value; }
        public int Consumo { get => Consumo; set => Consumo = value; }
        public string Aspiracion { get => aspiracion; set => aspiracion = value; }
        public int Potencia{ get => Potencia; set => Potencia = value; }
        public int torque { get => Torque; set => Torque = value; }
        public string transmision { get => Transmision; set => Transmision = value; }
        public string embrage { get => Embrage; set => Embrage = value; }
        public string liquido { get => Liquido; set => Liquido = value; }
        public string Escape { get => escape; set => escape = value; }
        public string Ecu1 { get => Ecu; set => Ecu = value; }
        public string suspension { get => Suspension; set => Suspension = value; }
        public int valor { get => Valor; set => Valor = value; }
        public string frenos { get => Frenos; set => Frenos = value; }
        public string traccion { get => Traccion; set => Traccion = value; }
        public string marca { get => Marca; set => Marca = value; }
        public string modelo { get => Modelo; set => Modelo = value; }
        public string ModeloMotor { get => modeloMotor; set => modeloMotor = value; }
        public string freno { get => Freno; set => Freno = value; }
    }
}
   