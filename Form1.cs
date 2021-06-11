using gggg.ModelBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Printing;
using System.Windows.Forms;


namespace gggg
{
    public partial class Form1 : Form
    {
        ModelBD.Model1 connect = new ModelBD.Model1();


        public Form1()
        {
            InitializeComponent();
            connect.Construcrions.Load();
            dataGridView1.DataSource = connect.Construcrions.Local.ToBindingList();

        }

        private void add1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            DialogResult result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                ModelBD.Construcrions cliadd = new Construcrions();

                cliadd.Company = form.textBox1.Text;
                cliadd.Time = form.textBox2.Text;
                cliadd.CLIENT = form.textBox3.Text;
                cliadd.TYPE = form.textBox4.Text;


                connect.Construcrions.Add(cliadd);
                connect.SaveChanges();
                MessageBox.Show("Добавлен");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == true)
                {
                    Construcrions Clientdel = connect.Construcrions.Find(id);
                    connect.Construcrions.Remove(Clientdel);
                    connect.SaveChanges();
                    string buff = Clientdel.Company;
                    MessageBox.Show("Запись " + buff + " была удалена!");
                }

            }
            else
            {
                MessageBox.Show("Запись не выбрана!");
            }





        }

        private void redakted_Click(object sender, EventArgs e)
        {
            Form2 formedit = new Form2();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);


                Construcrions clientedit = connect.Construcrions.Find(id);

                formedit.textBox1.Text = clientedit.Company;
                formedit.textBox2.Text = clientedit.Time;
                formedit.textBox3.Text = clientedit.CLIENT;
                formedit.textBox4.Text = clientedit.TYPE;

                DialogResult resultedit = formedit.ShowDialog(this);
                if (resultedit == DialogResult.OK)
                {
                    clientedit.Company = formedit.textBox1.Text;
                    clientedit.Time = formedit.textBox2.Text;
                    clientedit.CLIENT = formedit.textBox3.Text;
                    clientedit.TYPE = formedit.textBox4.Text;

                    connect.SaveChanges();
                    dataGridView1.Refresh();
                    MessageBox.Show("Объект изменен");

                }
            }

        }
        private void close_Click(object sender, EventArgs e)
        {

            {
                Close();
            }
        }
    }
}
  




