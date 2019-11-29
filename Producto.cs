using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PROBLEMA
{
     public class Producto
    {
        private string codigo;
        private string nombre;
        private double precio;
        private string descripcion;
        private string foto;
        private string dia;
        public string Codigo
        {
            get { return codigo; }
            set
            {
                if (value.Length <= 10)
                {
                    codigo = value;
                }
                else
                {
                    throw new Exception("La Cantidad de Carateres tiene que ser menor o igual a 10");
                }
                
            }   
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Precio
        {
            get { return precio.ToString(); }
            set
            {
                if (value.Length > 0)
                {
                    try
                    {
                        precio = double.Parse(value);

                    }
                    catch (Exception)
                    {
                        throw new Exception("El Dato no es un numero ");                        
                    }
                }
                else
                {
                    throw new Exception("El Dato no es un numero ");
                }
            }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public void Registrar()
        {
            Datos.Productos.Add(this);
        }
        public void Modificar()
        {
            Datos.Productos.Add(this);
        }
        public void Eliminar()
        {
            Datos.Productos.Remove(this);
        }
        public static List<Producto> Listar() 
        {
            return Datos.Productos;
        }
        public static List<Producto> Buscar(string texto)
        {
            return Datos.Productos.Where(o=>o.Nombre.ToUpper().Contains(texto.ToUpper()) ).ToList();
        }
    }
}
