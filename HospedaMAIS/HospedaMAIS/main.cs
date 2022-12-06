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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            FillLabels();
        }

        private void cadastrarHotelButton_Click(object sender, EventArgs e)
        {
            cadastrar_hotel cadastrar_hotel = new cadastrar_hotel(false, null, null, null, null, null, null, null, null);
            cadastrar_hotel.ShowDialog();
            FillLabels();
        }

        private void consultarHotelButton_Click_1(object sender, EventArgs e)
        {
            consultar_hotel consultar_hotel = new consultar_hotel();
            consultar_hotel.ShowDialog();
            FillLabels();
        }

        private void reservarQuartoButton_Click(object sender, EventArgs e)
        {
            reservar_quarto reservar_quarto = new reservar_quarto(false, null, null, null, null, null, null, null);
            reservar_quarto.ShowDialog();
            FillLabels();
        }

        private void consultarQuartoButton_Click(object sender, EventArgs e)
        {
            consultar_quarto consultar_quarto = new consultar_quarto();
            consultar_quarto.ShowDialog();
            FillLabels();
        }

        private void cadastrarClienteButton_Click(object sender, EventArgs e)
        {
            cadastrar_cliente cadastrar_cliente = new cadastrar_cliente(false, null, null, null, null, null, null, null);
            cadastrar_cliente.ShowDialog();
            FillLabels();
        }

        private void consultarClienteButton_Click(object sender, EventArgs e)
        {
            consultar_cliente consultar_cliente = new consultar_cliente();
            consultar_cliente.ShowDialog();
            FillLabels();
        }

        public void FillLabels()
        {
            database db = new database();
            DataTable dt_quartosAtivos = new DataTable();
            DataTable dt_hoteisAtivos = new DataTable();
            DataTable dt_quartosReservados = new DataTable();
            DataTable dt_countClientes = new DataTable();

            DataTable dt_despesaDia= new DataTable();
            DataTable dt_despesaSemana= new DataTable();
            DataTable dt_despesaMes= new DataTable();

            DataTable dt_lucroBrutoDia = new DataTable();
            DataTable dt_lucroBrutoSemana = new DataTable();
            DataTable dt_lucroBrutoMes = new DataTable();

            DataTable dt_lucroLiquidoDia = new DataTable();
            DataTable dt_lucroLiquidoSemana = new DataTable();
            DataTable dt_lucroLiquidoMes = new DataTable();

            db.OpenDatabaseConnection();

            dt_quartosAtivos = db.SelectQuartosAtivos();
            foreach (DataRow tmp in dt_quartosAtivos.Rows)
            {
                quartosAtivosLabel.Text = "Quartos ativos: " + tmp["sum(quartos)"].ToString();
            }

            dt_hoteisAtivos = db.SelectHoteisAtivos();
            foreach (DataRow tmp in dt_hoteisAtivos.Rows)
            {
                hoteisAtivosLabel.Text = "Hoteis ativos: " + tmp["count(id)"].ToString();
            }

            dt_quartosReservados = db.SelectQuartosReservados();
            foreach (DataRow tmp in dt_quartosReservados.Rows)
            {
                quartosReservadosLabel.Text = "Quartos reservados: " + tmp["count(id)"].ToString();
            }

            dt_countClientes = db.SelectCountClientes();
            foreach (DataRow tmp in dt_countClientes.Rows)
            {
                clientesTotaisLabel.Text = "Clientes totais: " + tmp["count(id)"].ToString();
            }

            dt_despesaDia = db.SelectDespesaDia();
            foreach (DataRow tmp in dt_despesaDia.Rows)
            {
                despesasDiaLabel.Text = "Despesas totais: " + tmp["total"].ToString();
            }

            dt_despesaSemana = db.SelectDespesaSemana();
            foreach (DataRow tmp in dt_despesaSemana.Rows)
            {
                despesasSemanaLabel.Text = "Despesas totais: " + tmp["total"].ToString();
            }

            dt_despesaMes = db.SelectDespesaMes();
            foreach (DataRow tmp in dt_despesaMes.Rows)
            {
                despesasMesLabel.Text = "Despesas totais: " + tmp["total"].ToString();
            }

            dt_lucroBrutoDia = db.SelectLucroBrutoDia();
            foreach (DataRow tmp in dt_lucroBrutoDia.Rows)
            {
                lucroBrutoDiaLabel.Text = "Lucro bruto: " + tmp["total"].ToString();
            }

            dt_lucroBrutoSemana = db.SelectLucroBrutoSemana();
            foreach (DataRow tmp in dt_lucroBrutoSemana.Rows)
            {
                lucroBrutoSemanaLabel.Text = "Lucro bruto: " + tmp["total"].ToString();
            }

            dt_lucroBrutoMes = db.SelectLucroBrutoMes();
            foreach (DataRow tmp in dt_lucroBrutoMes.Rows)
            {
                lucroBrutoMesLabel.Text = "Lucro bruto: " + tmp["total"].ToString();
            }

            dt_lucroLiquidoDia = db.SelectLucroLiquidoDia();
            foreach (DataRow tmp in dt_lucroLiquidoDia.Rows)
            {
                lucroLiquidoDiaLabel.Text = "Lucro liquido: " + tmp["total"].ToString();
            }

            dt_lucroLiquidoSemana = db.SelectLucroLiquidoSemana();
            foreach (DataRow tmp in dt_lucroLiquidoSemana.Rows)
            {
                lucroLiquidoSemanaLabel.Text = "Lucro liquido: " + tmp["total"].ToString();
            }

            dt_lucroLiquidoMes = db.SelectLucroLiquidoMes();
            foreach (DataRow tmp in dt_lucroLiquidoMes.Rows)
            {
                lucroLiquidoMesLabel.Text = "Lucro liquido: " + tmp["total"].ToString();
            }
            db.CloseDatabaseConnection();
        }
    }
}
