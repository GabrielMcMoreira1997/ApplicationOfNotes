using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Notas
{
    public partial class Form1 : Form
    {
        DataTable Table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Table = new DataTable();
            Table.Columns.Add("Título", typeof(string));
            Table.Columns.Add("Mensagem", typeof(string));

            dataGridView1.DataSource = Table;
            dataGridView1.Columns["Mensagem"].Visible = false;
            dataGridView1.Columns["Título"].Width = 235;
        }

        private void bttnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            Table.Rows.Add(txtTitle.Text, txtMessage.Text);

            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void bttnRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if(index > -1)
            {
                txtTitle.Text = Table.Rows[index]["Título"].ToString();
                txtMessage.Text = Table.Rows[index]["Mensagem"].ToString();
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            Table.Rows[index].Delete();

            txtTitle.Clear();
            txtMessage.Clear();
        }
    }
}
