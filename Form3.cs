using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imperador_Homologação
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form2 obj2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'imperador2DataSet2.Table_1'. Você pode movê-la ou removê-la conforme necessário.
            this.table_1TableAdapter.Fill(this.imperador2DataSet2.Table_1);

        }
    }
}
