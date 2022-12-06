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
    public partial class registrar : Form
    {
        public registrar()
        {
            InitializeComponent();
            senhaTextBox.PasswordChar = '*';
            confirmarSenhaTextBox.PasswordChar = '*';
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarButton_Click(object sender, EventArgs e)
        {
            if (senhaTextBox.Text == confirmarSenhaTextBox.Text)
            {
                database db = new database();
                try
                {
                    db.OpenDatabaseConnection();
                    db.InsertCommandUsuario(GetFormValues());
                    db.CloseDatabaseConnection();
                    MessageBox.Show("SUCESSO");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database conection failed: {ex.Message}");
                }
            }
            else if (senhaTextBox.Text == "" || confirmarSenhaTextBox.Text == "")
            {
                MessageBox.Show("Preencha todos os campos corretamente para se registrar.", "Aviso");
            }
            else
            {
                MessageBox.Show("O campo senha e confirmar senha não estão iguais.", "Aviso");
            }
            
        }

        private Usuario_values GetFormValues()
        {
            Usuario_values usuario_values = new Usuario_values();

            usuario_values.Usuario_usuario = usuarioTextBox.Text;
            usuario_values.Usuario_senha = senhaTextBox.Text;

            return usuario_values;
        }
    }
}
