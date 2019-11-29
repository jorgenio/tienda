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
    public partial class FrmVenta : Form
    {
        double total = 0;
        public static List<Item> detalle = new List<Item>();
        Item d;
        public FrmVenta()
        {
          
            InitializeComponent();
            textBox1.Text=Venta.GetNumero().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProductos2 d = new FrmProductos2();
            d.ShowDialog();
            ListarDetalle();
        }
        private void ListarDetalle() 
        {
            total = 0;
          
            dataGridView1.Rows.Clear();
            for (int i = 0; i < detalle.Count; i++)
            {
                d = detalle[i];
                total += d.Subtotal;
        
                dataGridView1.Rows.Add(d.Codigo, d.Nombre, d.Precio,d.Cantidad,d.Subtotal);
                dataGridView1.Rows[i].Tag=d;
                
            }
            label7.Text = "Total: " + total.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = (Item)dataGridView1.CurrentRow.Tag;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (d!=null)
            {
                detalle.Remove(d);
                ListarDetalle();
            }
            else
            {
                MessageBox.Show("Debes Seleccionar Un Item Para que Eliminar");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Venta o = new Venta();
            o.Numero=int.Parse(textBox1.Text);
            o.Nit = int.Parse( textBox2.Text);
            o.Nombre = textBox3.Text;
            o.Fecha = dateTimePicker1.Value;
            o.Total = total;
            foreach (Item i in detalle )
            {
                o.Detalle.Add(i);
                
            }
            o.Registrar();
            MessageBox.Show("Venta Realizada Con Exito");
            textBox1.Text= Venta.GetNumero().ToString();
            textBox2.Clear();
            textBox3.Clear();
            detalle.Clear();
            ListarDetalle();

            
        }

    }
}
