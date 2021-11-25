using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Imperador_Homologação
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        private string strCon = "Data Source=.;Initial Catalog=Imperador2;Integrated Security=True";
        private string strSql = string.Empty;

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            {
                tsbNovo.Enabled = false;
                tsbSalvar.Enabled = true;
                tsbAlterar.Enabled = false;
                tsbCancelar.Enabled = true;
                tsbExcluir.Enabled = false;
                tstIDBuscar.Enabled = true;
                tstIDBuscar.Enabled = false;
                txtId.Enabled = true;
                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                mkdCelular.Enabled = true;
                mkdCheckIn.Enabled = true;
                mkdCheckOut.Enabled = true;
                mkdCPF.Enabled = true;
                cbbQuarto.Enabled = true;
                txtValor.Enabled = true;
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tstIDBuscar.Enabled = true;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mkdCelular.Enabled = false;
            mkdCheckIn.Enabled = false;
            mkdCheckOut.Enabled = false;
            mkdCPF.Enabled = false;
            cbbQuarto.Enabled = false;
            txtValor.Enabled = false;

            txtId.Text = "";
            tstIDBuscar.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            cbbQuarto.Text = "";
            mkdCelular.Text = "";
            mkdCPF.Text = "";
            mkdCheckIn.Text = "";
            mkdCheckOut.Text = "";
            txtValor.Text = "";

        }

         private void tsbSalvar_Click(object sender, EventArgs e)
         {
            {
                strSql = "insert into Table_1 (CodReserva, CPF, Nome, Email, Celular, Quarto, CheckIn, CheckOut, Pagamento) values (@CodReserva, @CPF, @Nome, @Email, @Celular, @Quarto, @CheckIn, @CheckOut, @Pagamento)";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);








                comando.Parameters.Add("CodReserva", SqlDbType.Int).Value = txtId.Text;
                comando.Parameters.Add("CPF", SqlDbType.VarChar).Value = mkdCPF.Text;
                comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = txtNome.Text;
                comando.Parameters.Add("Email", SqlDbType.VarChar).Value = txtEmail.Text;
                comando.Parameters.Add("Celular", SqlDbType.VarChar).Value = mkdCelular.Text;
                comando.Parameters.Add("Quarto", SqlDbType.Int).Value = cbbQuarto.Text;
                comando.Parameters.Add("CheckIn", SqlDbType.Date).Value = mkdCheckIn.Text;
                comando.Parameters.Add("CheckOut", SqlDbType.Date).Value = mkdCheckOut.Text;
                comando.Parameters.Add("Pagamento", SqlDbType.VarChar).Value = txtValor.Text;


                try
                {

                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Reserva incluida com sucesso!");
                }

                catch (Exception)
                {

                    MessageBox.Show("ID Reserva existente");

                }

                finally
                {
                    sqlCon.Close();


                }

                tsbNovo.Enabled = true;
                tsbSalvar.Enabled = false;
                tsbAlterar.Enabled = false;
                tsbCancelar.Enabled = false;
                tsbExcluir.Enabled = false;
                tstIDBuscar.Enabled = true;
                mkdCPF.Enabled = false;
                txtNome.Enabled = false;
                txtEmail.Enabled = false;
                mkdCelular.Enabled = false;
                cbbQuarto.Enabled = false;
                mkdCheckIn.Enabled = false;
                mkdCheckOut.Enabled = false;
                txtValor.Enabled = false;


                txtId.Enabled = false;
                txtId.Text = "";
                tstIDBuscar.Text = "";
                txtNome.Text = "";
                txtEmail.Text = "";
                cbbQuarto.Text = "";
                mkdCelular.Text = "";
                mkdCPF.Text = "";
                mkdCheckIn.Text = "";
                mkdCheckOut.Text = "";
                txtValor.Text = "";

            }

        }
        
        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            strSql = "update Table_1 set CodReserva=@CodReserva, CPF=@CPF, Nome=@Nome, Email=@Email, Celular=@Celular, Quarto=@Quarto, CheckIn=@CheckIn, CheckOut=@CheckOut, Pagamento=@Pagamento where CodReserva = @IDBuscar";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@IDBuscar", SqlDbType.Int).Value = tstIDBuscar.Text;

            comando.Parameters.Add("CodReserva", SqlDbType.Int).Value = txtId.Text;
            comando.Parameters.Add("CPF", SqlDbType.VarChar).Value = mkdCPF.Text;
            comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("Email", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("Celular", SqlDbType.VarChar).Value = mkdCelular.Text;
            comando.Parameters.Add("Quarto", SqlDbType.Int).Value = cbbQuarto.Text;
            comando.Parameters.Add("CheckIn", SqlDbType.Date).Value = mkdCheckIn.Text;
            comando.Parameters.Add("CheckOut", SqlDbType.Date).Value = mkdCheckOut.Text;
            comando.Parameters.Add("Pagamento", SqlDbType.VarChar).Value = txtValor.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {

                sqlCon.Close();
            }


            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = true;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = true;
            tstIDBuscar.Enabled = true;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mkdCelular.Enabled = false;
            mkdCheckIn.Enabled = false;
            mkdCheckOut.Enabled = false;
            mkdCPF.Enabled = false;
            cbbQuarto.Enabled = false;
            txtValor.Enabled = false;

            txtId.Text = "";
            tstIDBuscar.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            cbbQuarto.Text = "";
            mkdCelular.Text = "";
            mkdCPF.Text = "";
            mkdCheckIn.Text = "";
            mkdCheckOut.Text = "";
            txtValor.Text = "";
        }
       
        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir a reserva?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)

            {

                MessageBox.Show("Operação cancelada!");

            }

            else
            {

                strSql = "Delete from Table_1 where CodReserva = @CodReserva";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("CodReserva", SqlDbType.Int).Value = tstIDBuscar.Text;

                try
                {

                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Reserva excluida com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }

                finally
                {

                    sqlCon.Close();
                }

                tsbNovo.Enabled = true;
                tsbSalvar.Enabled = false;
                tsbAlterar.Enabled = false;
                tsbCancelar.Enabled = false;
                tsbExcluir.Enabled = false;
                tstIDBuscar.Enabled = true;
                tsbBuscar.Enabled = true;
                txtNome.Enabled = false;
                txtEmail.Enabled = false;
                mkdCelular.Enabled = false;
                mkdCheckIn.Enabled = false;
                mkdCheckOut.Enabled = false;
                mkdCPF.Enabled = false;
                cbbQuarto.Enabled = false;
                txtValor.Enabled = false;
                

                txtId.Text = "";
                tstIDBuscar.Text = "";
                txtNome.Text = "";
                txtEmail.Text = "";
                cbbQuarto.Text = "";
                mkdCelular.Text = "";
                mkdCPF.Text = "";
                mkdCheckIn.Text = "";
                mkdCheckOut.Text = "";
                txtValor.Text = "";
                
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            strSql = "Select * from Table_1 where CodReserva = @CodReserva";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@CodReserva", SqlDbType.Int).Value = tstIDBuscar.Text;

            try
            {
                if (tstIDBuscar.Text == string.Empty)
                {

                    throw new Exception("Você precisa digitar um ID!");

                }
                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)


                {

                    throw new Exception("ID Não encontrado! Prosseguir com cadastro.");
                }

                dr.Read();
                txtId.Text = Convert.ToString(dr["CodReserva"]);
                mkdCPF.Text = Convert.ToString(dr["CPF"]);
                txtNome.Text = Convert.ToString(dr["Nome"]);
                txtEmail.Text = Convert.ToString(dr["Email"]);
                mkdCelular.Text = Convert.ToString(dr["Celular"]);
                cbbQuarto.Text = Convert.ToString(dr["Quarto"]);
                mkdCheckIn.Text = Convert.ToString(dr["CheckIn"]);
                mkdCheckOut.Text = Convert.ToString(dr["CheckOut"]);
                txtValor.Text = Convert.ToString(dr["Pagamento"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            finally
            {
                sqlCon.Close();

            }

            tsbNovo.Enabled = false;
            tsbSalvar.Enabled = false;
            tsbAlterar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = true;
            tstIDBuscar.Enabled = true;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mkdCelular.Enabled = true;
            mkdCheckIn.Enabled = true;
            mkdCheckOut.Enabled = true;
            mkdCPF.Enabled = true;
            cbbQuarto.Enabled = true;
            txtValor.Enabled = true;
            tsbBuscar.Text = "";
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            Form3 obj2 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            Form4 obj2 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void graficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            Form5 obj2 = new Form5();
            this.Hide();
            form5.Show();
        }
    }
 }
    

