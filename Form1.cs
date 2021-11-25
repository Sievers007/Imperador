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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "Master") && (textBox2.Text == "123456")) // Se o Usuário digitar os valores corretos, abrir o form2

            {
                Form2 form2 = new Form2();
                form1 obj2 = new form1();
                this.Hide();
                form2.Show();


            }
            else
            {
                MessageBox.Show("Login ou Senha invalidos!!"); //  Se o usuário não digitar correto, exibir a mensagem.

            }
        }
    }
}
