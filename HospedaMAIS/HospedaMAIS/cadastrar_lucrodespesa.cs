using Google.Protobuf.WellKnownTypes;
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
    public partial class cadastrar_lucrodespesa : Form
    {
        string id_t;
        bool edit_mode_t;
        public cadastrar_lucrodespesa(bool edit_mode, string id, string hotel_id, string valor, string data_registro)
        {
            InitializeComponent();
            DateTime date_time = DateTime.Now;
            dataRegistroTextBox.Text = date_time.ToString("yyyy/MM/dd HH:mm:ss");
            if (edit_mode)
            {
                hotelIdTextBox.Text = hotel_id;
                valorTextBox.Text = valor;
                dataRegistroTextBox.Text = data_registro;
                id_t = id;
                edit_mode_t = edit_mode;

                excluirButton.Enabled = true;
                cadastrarButton.Text = "Atualizar";
            }
        }

        private void limparCamposButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            hotelIdTextBox.Text = "";
            valorTextBox.Text = "";
            dataRegistroTextBox.Text = "";
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            database db = new database();

            if(lucroRadioButton.Checked)
            {
                try
                {
                    db.OpenDatabaseConnection();
                    if (edit_mode_t)
                    {
                        db.UpdateCommandLucro(GetFormValues(), id_t);
                    }
                    else
                    {
                        db.InsertCommandLucro(GetFormValues());
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
            else
            {
                try
                {
                    db.OpenDatabaseConnection();
                    if (edit_mode_t)
                    {
                        db.UpdateCommandDespesa(GetFormValues(), id_t);
                    }
                    else
                    {
                        db.InsertCommandDespesa(GetFormValues());
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
        }

        private Lucrodespesa_values GetFormValues()
        {
            Lucrodespesa_values lucrodespesa_values = new Lucrodespesa_values();

            lucrodespesa_values.Lucrodespesa_hotel_id = hotelIdTextBox.Text;
            lucrodespesa_values.Lucrodespesa_valor = valorTextBox.Text;
            lucrodespesa_values.Lucrodespesa_data_registro = dataRegistroTextBox.Text;

            return lucrodespesa_values;
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database db = new database();
                db.OpenDatabaseConnection();

                if(lucroRadioButton.Checked)
                {
                    db.DeleteCommandLucro(id_t);
                }
                else
                {
                    db.DeleteCommandDespesa(id_t);
                }
                
                MessageBox.Show("SUCESSO");
                db.CloseDatabaseConnection();
                this.Close();
            }
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
