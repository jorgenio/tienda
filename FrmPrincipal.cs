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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            Producto d = new Producto();
            d.Codigo = "1";
            d.Nombre = "2";
            d.Precio = "3";
            d.Descripcion = "producto";
            d.Foto = "D://robin.png";
            d.Registrar();
            Producto dd = new Producto();
            dd.Codigo = "2";
            dd.Nombre = "3";
            dd.Precio = "4";
            dd.Descripcion = "producto";
            dd.Foto = "D://robin.png";
            dd.Registrar();

        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 D = new Form1();
            D.ShowDialog();
        }

        private void ventaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVenta D = new FrmVenta();
            D.ShowDialog();
        }

        private void verVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerventas form = new FormVerventas();
            form.ShowDialog();
        }
    }
}
