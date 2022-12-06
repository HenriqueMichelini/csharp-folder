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
    public partial class consultar_quarto : Form
    {
        public consultar_quarto()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            database db = new database();
            db.OpenDatabaseConnection();
            dataGridView1.DataSource = db.SelectQuarto();
            db.CloseDatabaseConnection();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            database db = new database();
            db.OpenDatabaseConnection();

            bool edit_mode = true;

            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            string hotel = dataGridView1.Rows[e.RowIndex].Cells["hotel"].FormattedValue.ToString();
            string numero = dataGridView1.Rows[e.RowIndex].Cells["numero"].FormattedValue.ToString();
            string cliente = dataGridView1.Rows[e.RowIndex].Cells["cliente"].FormattedValue.ToString();
            string unidade_federativa = dataGridView1.Rows[e.RowIndex].Cells["unidade_federativa"].FormattedValue.ToString();
            string cpfcnpj = dataGridView1.Rows[e.RowIndex].Cells["cpfcnpj"].FormattedValue.ToString();
            string acompanhantes = dataGridView1.Rows[e.RowIndex].Cells["acompanhantes"].FormattedValue.ToString();

            reservar_quarto Reservar_quarto = new reservar_quarto(edit_mode, id, hotel, numero, cliente, unidade_federativa, cpfcnpj, acompanhantes);
            Reservar_quarto.ShowDialog();

            db.CloseDatabaseConnection();
            this.Close();
            InitializeDataGrid();
        }
    }
}
