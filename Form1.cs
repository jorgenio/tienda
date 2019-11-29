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
    public partial class Form1 : Form
    {
        Producto d ;
        
        public Form1()
        {
            InitializeComponent();
            Listar();
        }
        public void Listar() 
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                d = new Producto();
                CargarDatos();            
                d.Registrar();
                Listar();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
        
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (d != null)
            {
                try
                {
                    CargarDatos();
                  //  d.Modificar();
                    Listar();
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }

            }
            else
            {
                MessageBox.Show("Debe Selecionar un item para editar");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (d != null)
            {
                d.Eliminar();
                Listar();
            }
            else
            {
                MessageBox.Show("Debe Selecionar un item para editar");
            }
        }
        private void CargarDatos() 
        {
            d.Codigo = textBox1.Text;
            d.Nombre = textBox2.Text;
            d.Precio = textBox3.Text;
            d.Descripcion = textBox4.Text;
            d.Foto = pictureBox1.ImageLocation;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = (Producto)dataGridView1.CurrentRow.Tag;
            textBox1.Text = d.Codigo;
            textBox2.Text = d.Nombre;
            textBox3.Text = d.Precio;
            textBox4.Text = d.Descripcion;
            pictureBox1.ImageLocation = d.Foto;
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            Listar();
        }
    
    }
}
