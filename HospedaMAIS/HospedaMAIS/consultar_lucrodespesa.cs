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
    public partial class consultar_lucrodespesa : Form
    {
        public consultar_lucrodespesa()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            database db = new database();
            db.OpenDatabaseConnection();
            dataGridView1.DataSource = db.SelectLucrodespesa();
            db.CloseDatabaseConnection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            database db = new database();
            db.OpenDatabaseConnection();

            bool edit_mode = true;

            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            string hotel_id = dataGridView1.Rows[e.RowIndex].Cells["hotel_id"].FormattedValue.ToString();
            string valor = dataGridView1.Rows[e.RowIndex].Cells["valor"].FormattedValue.ToString();
            string data_registro = dataGridView1.Rows[e.RowIndex].Cells["data_registro"].FormattedValue.ToString();

            cadastrar_lucrodespesa Cadastrar_lucrodespesa = new cadastrar_lucrodespesa(edit_mode, id, hotel_id, valor, data_registro);
            Cadastrar_lucrodespesa.ShowDialog();

            db.CloseDatabaseConnection();
            InitializeDataGrid();
        }

        private void tipoSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            database db = new database();
            db.OpenDatabaseConnection();
            if (tipoSelectComboBox.GetItemText(tipoSelectComboBox.SelectedItem) == "Lucros") 
            {
                dataGridView1.DataSource = db.SelectLucro();
            }
            else if (tipoSelectComboBox.GetItemText(tipoSelectComboBox.SelectedItem) == "Despesas")
            {
                dataGridView1.DataSource = db.SelectDespesa();
            }
            else
            {
                dataGridView1.DataSource = db.SelectLucrodespesa();
            }
            db.CloseDatabaseConnection();
        }
    }
}
