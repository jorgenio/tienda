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
    public partial class FormVerventas : Form
    {

        public FormVerventas()
        {
            InitializeComponent();
            Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Listar()
        {

            dataGridView1.Rows.Clear();
            List<Venta> lista = Venta.Buscar(dateTimePicker1.Value,dateTimePicker2.Value);
  //          List<Venta> lista = Venta.Listar();
//            MessageBox.Show(lista.Count.ToString()+" - "+listad.Count.ToString());

            for (int i = 0; i < lista.Count; i++)
            {
                Venta d = lista[i];
                dataGridView1.Rows.Add(d.Numero, d.Nombre, d.Nit, d.Fecha);
                dataGridView1.Rows[i].Tag = d;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Venta d = (Venta)dataGridView1.CurrentRow.Tag;
            FormVerDetalle form = new FormVerDetalle(d.Detalle);
            form.ShowDialog();
            //d.Numero;

        }
    }
}
