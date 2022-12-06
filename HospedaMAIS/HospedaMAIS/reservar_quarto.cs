using MySqlX.XDevAPI;
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
    public partial class reservar_quarto : Form
    {
        string id_t;
        bool edit_mode_t = false;
        public reservar_quarto(bool edit_mode, string id, string hotel, string numero, string cliente, string unidade_federativa, string cpfcnpj, string acompanhantes)
        {
            InitializeComponent();

            if (edit_mode)
            {
                hotelTextBox.Text = hotel;
                numeroQuartoTextBox.Text = numero;
                nomeClienteTextBox.Text = cliente;
                unidadefederativaTextBox.Text = unidade_federativa;
                cpfcnpjTextBox.Text = cpfcnpj;
                acompanhantesTextBox.Text = acompanhantes;
                id_t = id;
                edit_mode_t = edit_mode;

                cadastrarButton.Text = "Atualizar";
                excluirButton.Visible = true;

            }
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparCamposButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            hotelTextBox.Text = "";
            numeroQuartoTextBox.Text = "";
            nomeClienteTextBox.Text = "";
            unidadefederativaTextBox.Text = "";
            cpfcnpjTextBox.Text = "";
            acompanhantesTextBox.Text = "";
        }

        private Quarto_values GetFormValues()
        {
            Quarto_values quarto_values = new Quarto_values();

            quarto_values.Quarto_hotel = hotelTextBox.Text;
            quarto_values.Quarto_cliente = nomeClienteTextBox.Text;
            quarto_values.Quarto_numero = numeroQuartoTextBox.Text;
            quarto_values.Quarto_unidade_federativa = unidadefederativaTextBox.Text;
            quarto_values.Quarto_cpfcnpj = cpfcnpjTextBox.Text;
            quarto_values.Quarto_acompanhantes = acompanhantesTextBox.Text;
            quarto_values.Quarto_id = id_t;

            return quarto_values;
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            database db = new database();
            try
            {
                db.OpenDatabaseConnection();
                main main = new main();
                if (edit_mode_t)
                {
                    db.UpdateCommandQuarto(GetFormValues(), id_t);
                    db.CloseDatabaseConnection();                  
                    MessageBox.Show("SUCESSO");
                    this.Close();
                }
                else
                {
                    db.InsertCommandQuarto(GetFormValues());
                    db.CloseDatabaseConnection();
                    ClearFields();
                    MessageBox.Show("SUCESSO");                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database conection failed: {ex.Message}");
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database db = new database();
                db.OpenDatabaseConnection();
                db.DeleteCommandReservarQuarto(id_t);
                MessageBox.Show("SUCESSO");
                db.CloseDatabaseConnection();
                this.Close();
            }
        }
    }
}
