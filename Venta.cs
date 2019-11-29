using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PROBLEMA
{
    class Venta
    {
        private int numero;
        private int nit;
        private string nombre;
        private DateTime fecha;
        private List<Item> detalle = new List<Item>();
        private double total;
        public int Numero 
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Nit
        {
            get { return nit; }
            set { nit = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public List<Item> Detalle 
        {
            get { return detalle; }
            set { detalle = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public static int GetNumero()
        {
            return Datos.Ventas.Count+1;
        }

        public void Registrar()
        {
            Datos.Ventas.Add(this);
        }
        public static List<Venta> Buscar(DateTime inicio, DateTime fin)
        {
            return Datos.Ventas.Where(o => o.Fecha.Date>=inicio && o.Fecha.Date <= fin).ToList();
//            return Datos.Ventas.Where(o => o.Fecha >= inicio).ToList();
        }
        public static List<Venta> Listar()
        {
            return Datos.Ventas.ToList();
        }

    }
}
