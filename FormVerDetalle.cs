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
    public partial class FormVerDetalle : Form
    {
        double total = 0;
        //public static List<Item> detalle = Datos;
        Item d;
        int codigo;
        public FormVerDetalle(List<Item> detalle)
        {
            InitializeComponent();
            //label1.Text = detalle.Count.ToString();
            ListarDetalle(detalle);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ListarDetalle(List<Item> detalle)
        {
            total = 0;

            dataGridView1.Rows.Clear();
            for (int i = 0; i < detalle.Count; i++)
            {
                d = detalle[i];
                total += d.Subtotal;
                dataGridView1.Rows.Add(d.Codigo, d.Nombre, d.Precio, d.Cantidad, d.Subtotal);
                dataGridView1.Rows[i].Tag = d;
                
        }
            label1.Text = "Total: " + total.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
