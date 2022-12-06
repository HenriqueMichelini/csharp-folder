using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospedaMAIS
{
    public partial class cadastrar_cliente : Form
    {
        string id_t;
        bool edit_mode_t;

        public cadastrar_cliente(bool edit_mode, string id, string nome, string sobrenome, string cidade, string unidade_federativa, string cpfcnpj, string cep)
        {
            InitializeComponent();

            if(edit_mode)
            {
                nomeTextBox.Text = nome;
                cpfcnpjTextBox.Text = cpfcnpj;
                sobrenomeTextBox.Text = sobrenome;
                cidadeTextBox.Text = cidade;
                unidadefederativaTextBox.Text = unidade_federativa;
                cepTextBox.Text = cep;
                id_t = id;
                edit_mode_t = edit_mode;

                cadastrarButton.Text = "Atualizar";
                excluirButton.Visible = true;
            }
        }
        void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparCamposButton_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            nomeTextBox.Text                = "";
            cpfcnpjTextBox.Text             = "";
            sobrenomeTextBox.Text           = "";
            cidadeTextBox.Text              = "";
            unidadefederativaTextBox.Text   = "";
            cepTextBox.Text                 = "";
        }

        private void cadastrarButton_Click_1(object sender, EventArgs e)
        {
            database db = new database();
            try
            {
                db.OpenDatabaseConnection();
                if(edit_mode_t)
                {
                    db.UpdateCommandCliente(GetFormValues(), id_t);
                }
                else
                {
                    db.InsertCommandCliente(GetFormValues());
                }
                db.CloseDatabaseConnection();
                ClearFields();
                MessageBox.Show("SUCESSO");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Database conection failed: {ex.Message}");
            }
        }

        private Cliente_values GetFormValues()
        {
            Cliente_values cliente_values = new Cliente_values();

            cliente_values.Cliente_nome = nomeTextBox.Text;
            cliente_values.Cliente_sobrenome = sobrenomeTextBox.Text;
            cliente_values.Cliente_cidade = cidadeTextBox.Text;
            cliente_values.Cliente_unidade_federativa = unidadefederativaTextBox.Text;
            cliente_values.Cliente_cpfcnpj = cpfcnpjTextBox.Text;
            cliente_values.Cliente_cep = cepTextBox.Text;
            cliente_values.Cliente_id = id_t;

            return cliente_values;
        }

        private void excluirButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database db = new database();
                db.OpenDatabaseConnection();
                db.DeleteCommandCliente(id_t);
                MessageBox.Show("SUCESSO");
                db.CloseDatabaseConnection();
                this.Close();
            }
        }
    }
}
