using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Logic;
namespace Tp_4
{
    public partial class Form1 : Form
    {
        private ProductLogic BaseDatos;
        List<Categories> Categorias;
        List<Shippers> Cargadores;

        public Form1()
        {
            InitializeComponent();
            BaseDatos = new ProductLogic();
            refreshCategories();
            refreshShippers();
            
          
        }
        private void refreshCategories()
        {
            Categorias = BaseDatos.GetCategories();
            textBox1.Text = "";
            textBox2.Text = "";
            dataGridView1.Rows.Clear();
            foreach (Categories cat in Categorias)
            {
                dataGridView1.Rows.Add(new string[] { cat.CategoryName, cat.Description });
            }
        }
        private void refreshShippers()
        {
            Cargadores = BaseDatos.GetShippers();
            textBox3.Text = "";
            textBox4.Text = "";
            dataGridView2.Rows.Clear();
            foreach (Shippers ship in Cargadores)
            {
                dataGridView2.Rows.Add(new string[] { ship.CompanyName, ship.Phone });
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CategoriesTab_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Categories Cat = Categorias[dataGridView1.CurrentCell.RowIndex];
            textBox1.Text = Cat.CategoryName;
            textBox2.Text = Cat.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Categories Cat = new Categories();
            Cat.CategoryName = textBox1.Text;
            Cat.Description = textBox2.Text;
            if (BaseDatos.AddCategory(Cat))
                refreshCategories();
            else
                MessageBox.Show("No se pudo agregar el elemento");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex > 0)
            {
                BaseDatos.DeleteCategory(Categorias[dataGridView1.CurrentCell.RowIndex]);
                refreshCategories();
            }
            else
                MessageBox.Show("Debe elegir un elemento haciendo doble clic en la tabla");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Categories Cat = Categorias[dataGridView1.CurrentCell.RowIndex];
            Cat.CategoryName = textBox1.Text;
            Cat.Description = textBox2.Text;
            BaseDatos.UpdateCategory(Cat);
            refreshCategories();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Shippers Ship = new Shippers();
            Ship.CompanyName = textBox4.Text;
            Ship.Phone = textBox3.Text;
            if (BaseDatos.AddShippers(Ship))
                refreshShippers();
            else
                MessageBox.Show("No se pudo agregar el elemento");

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (BaseDatos.DeleteShippers(Cargadores[dataGridView2.CurrentCell.RowIndex]))
                refreshShippers();
            else
                MessageBox.Show("No se puede eliminar el elemento");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Shippers Ship = Cargadores[dataGridView2.CurrentCell.RowIndex];
            Ship.CompanyName = textBox4.Text;
           Ship.Phone = textBox3.Text;
            if (BaseDatos.UpdateShippers(Ship))
                refreshShippers();
            else
                MessageBox.Show("No se puede modificar el elemento");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            Shippers Ship = Cargadores[dataGridView2.CurrentCell.RowIndex];
            textBox4.Text = Ship.CompanyName;
            textBox3.Text = Ship.Phone;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Categories Cat = Categorias[dataGridView1.CurrentCell.RowIndex];
            textBox1.Text = Cat.CategoryName;
            textBox2.Text = Cat.Description;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            Shippers Ship = Cargadores[dataGridView2.CurrentCell.RowIndex];
            textBox4.Text = Ship.CompanyName;
            textBox3.Text = Ship.Phone;
        }
    }
}
