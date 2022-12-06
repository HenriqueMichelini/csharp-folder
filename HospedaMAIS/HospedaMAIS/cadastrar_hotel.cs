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
    public partial class cadastrar_hotel : Form
    {
        string id_t;
        bool edit_mode_t;
        public cadastrar_hotel(bool edit_mode, string id, string nome, string capital, string cidade, string unidade_federativa, string quartos, string funcionarios, string cnpj)
        {
            InitializeComponent();
            if(edit_mode) 
            {
                double d_capital = Convert.ToDouble(capital);
                string s_capital = d_capital.ToString();
                nomeTextBox.Text = nome;
                quartosTextBox.Text = quartos;
                capitalTextBox.Text = s_capital;
                cidadeTextBox.Text = cidade;
                unidadefederativaTextBox.Text = unidade_federativa;
                funcionariosTextBox.Text = funcionarios;
                cnpjTextBox.Text = cnpj;
                id_t = id;
                edit_mode_t = edit_mode;

                cadastrarButton.Text = "Atualizar";
                excluirButton.Visible = true;
            }
        }

        private void limparCamposButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            nomeTextBox.Text = "";
            quartosTextBox.Text = "";
            capitalTextBox.Text = "";
            cidadeTextBox.Text = "";
            unidadefederativaTextBox.Text = "";
            funcionariosTextBox.Text = "";
            cnpjTextBox.Text = "";
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            database db = new database();
            try
            {
                db.OpenDatabaseConnection();
                if(edit_mode_t)
                {
                    db.UpdateCommandHotel(GetFormValues(), id_t);
                }
                else
                {
                    db.InsertCommandHotel(GetFormValues());
                }
                db.CloseDatabaseConnection();
                ClearFields();
                MessageBox.Show("SUCESSO");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database conection failed: {ex.Message}");
            }
        }

        private Hotel_values GetFormValues()
        {
            Hotel_values hotel_values = new Hotel_values();

            hotel_values.Hotel_nome = nomeTextBox.Text;
            hotel_values.Hotel_capital = capitalTextBox.Text;
            hotel_values.Hotel_cidade = cidadeTextBox.Text;
            hotel_values.Hotel_unidade_federativa = unidadefederativaTextBox.Text;
            hotel_values.Hotel_quartos = quartosTextBox.Text;
            hotel_values.Hotel_funcionarios = funcionariosTextBox.Text;
            hotel_values.Hotel_cnpj = cnpjTextBox.Text;
            hotel_values.Hotel_id = id_t;

            return hotel_values;
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database db = new database();
                db.OpenDatabaseConnection();
                db.DeleteCommandHotel(id_t);
                MessageBox.Show("SUCESSO");
                db.CloseDatabaseConnection();
                this.Close();
            }
        }
    }
}