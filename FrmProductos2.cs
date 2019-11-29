using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07PROBLEMA
{
    public partial class FrmProductos2 : Form
    {
        Producto d;
        public FrmProductos2()
        {
            InitializeComponent();
            ListarProductos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ListarProductos() 
        {
                 
            List<Producto> lista = Producto.Buscar(textBox5.Text);            
            dataGridView1.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                d = lista[i];
                Bitmap foto = new Bitmap(d.Foto);
                dataGridView1.Rows.Add(d.Codigo, d.Nombre, d.Precio, d.Descripcion, foto);
                dataGridView1.Rows[i].Tag=d;                
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            ListarProductos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = (Producto)dataGridView1.CurrentRow.Tag;
            Item o = new Item();
            o.Codigo=d.Codigo;
            o.Nombre = d.Nombre;
            o.Precio = double.Parse(d.Precio);
            o.Cantidad = 1;
            o.Subtotal=o.Precio*o.Cantidad;            
            FrmVenta.detalle.Add(o);
            this.Close();
        }
    }
}
