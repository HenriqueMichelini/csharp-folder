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
    public partial class consultar_cliente : Form
    {
        public consultar_cliente()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            database db = new database();
            db.OpenDatabaseConnection();
            dataGridView1.DataSource = db.SelectCliente();
            db.CloseDatabaseConnection();
        }

        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            database db = new database();
            db.OpenDatabaseConnection();

            bool edit_mode = true;

            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            string nome = dataGridView1.Rows[e.RowIndex].Cells["nome"].FormattedValue.ToString();
            string sobrenome = dataGridView1.Rows[e.RowIndex].Cells["sobrenome"].FormattedValue.ToString();
            string cidade = dataGridView1.Rows[e.RowIndex].Cells["cidade"].FormattedValue.ToString();
            string unidade_federativa = dataGridView1.Rows[e.RowIndex].Cells["unidade_federativa"].FormattedValue.ToString();
            string cpfcnpj = dataGridView1.Rows[e.RowIndex].Cells["cpfcnpj"].FormattedValue.ToString();
            string cep = dataGridView1.Rows[e.RowIndex].Cells["cep"].FormattedValue.ToString();

            cadastrar_cliente Cadastrar_cliente = new cadastrar_cliente(edit_mode, id, nome, sobrenome, cidade, unidade_federativa, cpfcnpj, cep);
            Cadastrar_cliente.ShowDialog();

            db.CloseDatabaseConnection();
            InitializeDataGrid();
        }
    }
}
