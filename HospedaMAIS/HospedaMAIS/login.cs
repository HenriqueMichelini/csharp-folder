using System.Data;
using System.Threading;

namespace HospedaMAIS
{
    public partial class login : Form
    {
        Thread thread;
        public login()
        {
            InitializeComponent();
            senhaTextBox.PasswordChar = '*';
        }

        private void registrarButton_Click(object sender, EventArgs e)
        {
            registrar registrar = new registrar();
            registrar.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt_usuario = new DataTable();

            
            //int exists = int.Parse(db.SelectCountUsuario(usuarioTextBox.Text));

            dt_usuario = db.SelectCountUsuario(usuarioTextBox.Text);
            db.OpenDatabaseConnection();

            if (usuarioTextBox.Text != "" || usuarioTextBox.Text != null)
            {
                foreach (DataRow tmp in dt_usuario.Rows)
                {
                    int exists = int.Parse((string)tmp["count(id)"]);
                    MessageBox.Show("" + exists);
                }
            }
            else
            {
                MessageBox.Show("Campos vazios!", "Aviso");
            }

            db.CloseDatabaseConnection();

            this.Close();
            thread = new Thread(OpenNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenNewForm(object obj)
        {
            Application.Run(new main());
        }
    }
}