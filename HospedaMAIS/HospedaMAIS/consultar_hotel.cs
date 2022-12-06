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
    public partial class consultar_hotel : Form
    {
        public consultar_hotel()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            database db = new database();
            db.OpenDatabaseConnection();
            dataGridView1.DataSource = db.SelectHotel();
            db.CloseDatabaseConnection();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            database db = new database();
            db.OpenDatabaseConnection();

            bool edit_mode = true;

            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            string nome = dataGridView1.Rows[e.RowIndex].Cells["nome"].FormattedValue.ToString();
            string capital = dataGridView1.Rows[e.RowIndex].Cells["capital"].FormattedValue.ToString();
            string cidade = dataGridView1.Rows[e.RowIndex].Cells["cidade"].FormattedValue.ToString();
            string unidade_federativa = dataGridView1.Rows[e.RowIndex].Cells["unidade_federativa"].FormattedValue.ToString();
            string quartos = dataGridView1.Rows[e.RowIndex].Cells["quartos"].FormattedValue.ToString();
            string funcionarios = dataGridView1.Rows[e.RowIndex].Cells["funcionarios"].FormattedValue.ToString();
            string cnpj = dataGridView1.Rows[e.RowIndex].Cells["cnpj"].FormattedValue.ToString();

            cadastrar_hotel Cadastrar_hotel = new cadastrar_hotel(edit_mode, id, nome, capital, cidade, unidade_federativa, quartos, funcionarios, cnpj);
            Cadastrar_hotel.ShowDialog();

            db.CloseDatabaseConnection();
            InitializeDataGrid();
        }

        private void consultarLucrodespesaButton_Click(object sender, EventArgs e)
        {
            consultar_lucrodespesa Consultarld = new consultar_lucrodespesa();
            Consultarld.ShowDialog();
        }

        private void cadastrarLucrodespesaButton_Click(object sender, EventArgs e)
        {
            cadastrar_lucrodespesa CadastrarLd = new cadastrar_lucrodespesa(false, null, null, null, null);
            CadastrarLd.ShowDialog();
        }
    }
}
