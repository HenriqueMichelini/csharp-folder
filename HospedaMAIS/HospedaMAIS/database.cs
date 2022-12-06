using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospedaMAIS
{
    internal class database
    {
        private MySqlConnection con;
        private MySqlCommand cmd;

        public void OpenDatabaseConnection()
        {
            con = new MySqlConnection("Server=127.0.0.1;User ID=root;Password=henrique;Database=HospedaMAIS;");
            con.Open();
        }

        public void CloseDatabaseConnection()
        {
            if (con != null) 
            { 
                con.Close();
                con.Dispose();
                con = null;
            }
        }

        private void ExecuteCommand(MySqlConnection command_connection, MySqlCommand command)
        {
            using (command)
            {
                command.Connection = command_connection;
                command.ExecuteNonQuery();
            }
        }

        public bool InsertCommandUsuario(Usuario_values Usuario_values)
        {
            MySqlCommand command = new MySqlCommand
            (
                "INSERT INTO usuario("  +
                "usuario,"              +
                "senha)"                +
                "VALUES("               +
                "@usuario,"             +
                "@senha);"
            );

            command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = Usuario_values.Usuario_usuario;
            command.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Usuario_values.Usuario_senha;

            try
            {
                ExecuteCommand(con, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public bool InsertCommandCliente(Cliente_values Cliente_values)
        {
            MySqlCommand command = new MySqlCommand
            (
                "INSERT INTO cliente("      +
                "nome,"                     +
                "sobrenome,"                +
                "cidade,"                   +
                "unidade_federativa,"       +
                "cpfcnpj,"                  +
                "cep)"                      +
                "VALUES("                   +
                "@nome,"                    +
                "@sobrenome,"               +
                "@cidade,"                  +
                "@unidade_federativa,"      +
                "@cpfcnpj,"                 +
                "@cep);"
            );

            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Cliente_values.Cliente_nome;
            command.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = Cliente_values.Cliente_sobrenome;
            command.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = Cliente_values.Cliente_cidade;
            command.Parameters.Add("@unidade_federativa", MySqlDbType.VarChar).Value = Cliente_values.Cliente_unidade_federativa;
            command.Parameters.Add("@cpfcnpj", MySqlDbType.VarChar).Value = Cliente_values.Cliente_cpfcnpj;
            command.Parameters.Add("@cep", MySqlDbType.VarChar).Value = Cliente_values.Cliente_cep;

            try
            {
                ExecuteCommand(con, command);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public bool InsertCommandHotel(Hotel_values Hotel_values)
        {
            MySqlCommand command = new MySqlCommand
            (
                "INSERT INTO hotel("    +
                "nome,"                 +
                "capital,"              +
                "cidade,"               +
                "unidade_federativa,"   +
                "quartos,"              +
                "funcionarios,"         +
                "cnpj)"                 +
                "VALUES("               +
                "@nome,"                +
                "@capital,"             +
                "@cidade,"              +
                "@unidade_federativa,"  +
                "@quartos,"             +
                "@funcionarios,"        +
                "@cnpj);"
            );

            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Hotel_values.Hotel_nome;
            command.Parameters.Add("@capital", MySqlDbType.VarChar).Value = Hotel_values.Hotel_capital;
            command.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = Hotel_values.Hotel_cidade;
            command.Parameters.Add("@unidade_federativa", MySqlDbType.VarChar).Value = Hotel_values.Hotel_unidade_federativa;
            command.Parameters.Add("@quartos", MySqlDbType.VarChar).Value = Hotel_values.Hotel_quartos;
            command.Parameters.Add("@funcionarios", MySqlDbType.VarChar).Value = Hotel_values.Hotel_funcionarios;
            command.Parameters.Add("@cnpj", MySqlDbType.VarChar).Value = Hotel_values.Hotel_cnpj;

            try
            {
                ExecuteCommand(con, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public bool InsertCommandQuarto(Quarto_values Quarto_values)
        {
            MySqlCommand command = new MySqlCommand
            (
                "INSERT INTO quarto("   +
                "hotel,"                +
                "numero,"               +
                "cliente,"              +
                "unidade_federativa,"   +
                "cpfcnpj,"              +
                "acompanhantes)"        +
                "VALUES("               +
                "@hotel,"               +
                "@numero,"              +
                "@cliente,"             +
                "@unidade_federativa,"  +
                "@cpfcnpj,"             +
                "@acompanhantes);"
            );

            command.Parameters.Add("@hotel", MySqlDbType.VarChar).Value = Quarto_values.Quarto_hotel;
            command.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Quarto_values.Quarto_numero;
            command.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = Quarto_values.Quarto_cliente;
            command.Parameters.Add("@unidade_federativa", MySqlDbType.VarChar).Value = Quarto_values.Quarto_unidade_federativa;
            command.Parameters.Add("@cpfcnpj", MySqlDbType.VarChar).Value = Quarto_values.Quarto_cpfcnpj;
            command.Parameters.Add("@acompanhantes", MySqlDbType.VarChar).Value = Quarto_values.Quarto_acompanhantes;

            try
            {
                ExecuteCommand(con, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public bool InsertCommandLucro(Lucrodespesa_values Lucrodespesa_values)
        {
            MySqlCommand command = new MySqlCommand
            (
                "INSERT INTO lucro("    +
                "hotel_id,"             +
                "valor,"                +
                "data_registro)"        +
                "VALUES("               +
                "@hotel_id,"            +
                "@valor,"               +
                "@data_registro);"
            );

            command.Parameters.Add("@hotel_id", MySqlDbType.VarChar).Value = Lucrodespesa_values.Lucrodespesa_hotel_id;
            command.Parameters.Add("@valor", MySqlDbType.VarChar).Value = Lucrodespesa_values.Lucrodespesa_valor;
            command.Parameters.Add("@data_registro", MySqlDbType.VarChar).Value = Lucrodespesa_values.Lucrodespesa_data_registro;

            try
            {
                ExecuteCommand(con, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public bool InsertCommandDespesa(Lucrodespesa_values Lucrodespesa_values)
        {
            MySqlCommand command = new MySqlCommand
            (
                "INSERT INTO despesa(" +
                "hotel_id," +
                "valor," +
                "data_registro)" +
                "VALUES(" +
                "@hotel_id," +
                "@valor," +
                "@data_registro);"
            );

            command.Parameters.Add("@hotel_id", MySqlDbType.VarChar).Value = Lucrodespesa_values.Lucrodespesa_hotel_id;
            command.Parameters.Add("@valor", MySqlDbType.VarChar).Value = Lucrodespesa_values.Lucrodespesa_valor;
            command.Parameters.Add("@data_registro", MySqlDbType.VarChar).Value = Lucrodespesa_values.Lucrodespesa_data_registro;

            try
            {
                ExecuteCommand(con, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public bool UpdateCommandQuarto(Quarto_values Quarto_values, string id)
        {

            MySqlCommand command = new MySqlCommand
            (
                "UPDATE quarto SET hotel = @hotel, numero = @numero, cliente = @cliente, unidade_federativa = @unidade_federativa, cpfcnpj = @cpfcnpj, acompanhantes = @acompanhantes WHERE id = @id;"
            );

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Quarto_values.Quarto_id;
            command.Parameters.Add("@hotel", MySqlDbType.VarChar).Value = Quarto_values.Quarto_hotel;
            command.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Quarto_values.Quarto_numero;
            command.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = Quarto_values.Quarto_cliente;
            command.Parameters.Add("@unidade_federativa", MySqlDbType.VarChar).Value = Quarto_values.Quarto_unidade_federativa;
            command.Parameters.Add("@cpfcnpj", MySqlDbType.VarChar).Value = Quarto_values.Quarto_cpfcnpj;
            command.Parameters.Add("@acompanhantes", MySqlDbType.VarChar).Value = Quarto_values.Quarto_acompanhantes;

            try
            {
                ExecuteCommand(con, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public bool UpdateCommandHotel(Hotel_values Hotel_values, string id)
        {

            MySqlCommand command = new MySqlCommand
            (
                "UPDATE hotel SET nome = @nome, capital = @capital, cidade = @cidade, unidade_federativa = @unidade_federativa, quartos = @quartos, funcionarios = @funcionarios, cnpj = @cnpj WHERE id = @id;"
            );

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Hotel_values.Hotel_id;
            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Hotel_values.Hotel_nome;
            command.Parameters.Add("@capital", MySqlDbType.VarChar).Value = Hotel_values.Hotel_capital;
            command.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = Hotel_values.Hotel_cidade;
            command.Parameters.Add("@unidade_federativa", MySqlDbType.VarChar).Value = Hotel_values.Hotel_unidade_federativa;
            command.Parameters.Add("@quartos", MySqlDbType.VarChar).Value = Hotel_values.Hotel_quartos;
            command.Parameters.Add("@funcionarios", MySqlDbType.VarChar).Value = Hotel_values.Hotel_funcionarios;
            command.Parameters.Add("@cnpj", MySqlDbType.VarChar).Value = Hotel_values.Hotel_cnpj;

            try
            {
                ExecuteCommand(con, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public bool UpdateCommandCliente(Cliente_values Cliente_values, string id)
        {

            MySqlCommand command = new MySqlCommand
            (
                "UPDATE cliente SET nome = @nome, sobrenome = @sobrenome, cidade = @cidade, unidade_federativa = @unidade_federativa, cpfcnpj = @cpfcnpj, cep = @cep WHERE id = @id;"
            );

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Cliente_values.Cliente_id;
            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Cliente_values.Cliente_nome;
            command.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = Cliente_values.Cliente_sobrenome;
            command.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = Cliente_values.Cliente_cidade;
            command.Parameters.Add("@unidade_federativa", MySqlDbType.VarChar).Value = Cliente_values.Cliente_unidade_federativa;
            command.Parameters.Add("@cpfcnpj", MySqlDbType.VarChar).Value = Cliente_values.Cliente_cpfcnpj;
            command.Parameters.Add("@cep", MySqlDbType.VarChar).Value = Cliente_values.Cliente_cep;

            try
            {
                ExecuteCommand(con, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public bool UpdateCommandLucro(Lucrodespesa_values Lucrodespesa_values, string id)
        {

            MySqlCommand command = new MySqlCommand
            (
                "UPDATE lucro SET hotel_id = @hotel_id, valor = @valor, data_registro = @data_registro WHERE id = @id;"
            );

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Lucrodespesa_values.Lucrodespesa_id;
            command.Parameters.Add("@hotel_id", MySqlDbType.VarChar).Value = Lucrodespesa_values.Lucrodespesa_hotel_id;
            command.Parameters.Add("@valor", MySqlDbType.VarChar).Value = Lucrodespesa_values.Lucrodespesa_valor;
            command.Parameters.Add("@data_registro", MySqlDbType.VarChar).Value = Lucrodespesa_values.Lucrodespesa_data_registro;

            try
            {
                ExecuteCommand(con, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public bool UpdateCommandDespesa(Lucrodespesa_values Lucrodespesa_values, string id)
        {

            MySqlCommand command = new MySqlCommand
            (
                "UPDATE despesa SET hotel_id = @hotel_id, valor = @valor, data_registro = @data_registro WHERE id = @id;"
            );

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Lucrodespesa_values.Lucrodespesa_id;
            command.Parameters.Add("@hotel_id", MySqlDbType.VarChar).Value = Lucrodespesa_values.Lucrodespesa_hotel_id;
            command.Parameters.Add("@valor", MySqlDbType.VarChar).Value = Lucrodespesa_values.Lucrodespesa_valor;
            command.Parameters.Add("@data_registro", MySqlDbType.VarChar).Value = Lucrodespesa_values.Lucrodespesa_data_registro;

            try
            {
                ExecuteCommand(con, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public bool DeleteCommandReservarQuarto(string id)
        {
            MySqlCommand command = new MySqlCommand
            (
                "DELETE FROM quarto WHERE id = '" + id + "';"
            );

            try
            {
                ExecuteCommand(con, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public bool DeleteCommandHotel(string id)
        {
            MySqlCommand command = new MySqlCommand
            (
                "DELETE FROM hotel WHERE id = '" + id + "';"
            );

            try
            {
                ExecuteCommand(con, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public bool DeleteCommandCliente(string id)
        {
            MySqlCommand command = new MySqlCommand
            (
                "DELETE FROM cliente WHERE id = '" + id + "';"
            );

            try
            {
                ExecuteCommand(con, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public bool DeleteCommandLucro(string id)
        {
            MySqlCommand command = new MySqlCommand
            (
                "DELETE FROM lucro WHERE id = '" + id + "';"
            );

            try
            {
                ExecuteCommand(con, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public bool DeleteCommandDespesa(string id)
        {
            MySqlCommand command = new MySqlCommand
            (
                "DELETE FROM despesa WHERE id = '" + id + "';"
            );

            try
            {
                ExecuteCommand(con, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execute command to database failed:{ex.Message}");
                CloseDatabaseConnection();
            }
            return true;
        }

        public DataTable SelectCliente()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM cliente;";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable SelectQuarto()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM quarto;";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable SelectHotel()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM hotel;";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable SelectQuartosAtivos()
        {
            DataTable dt = new DataTable();
            string query = "SELECT SUM(quartos) FROM hotel;";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable SelectHoteisAtivos()
        {
            DataTable dt = new DataTable();
            string query = "SELECT COUNT(id) FROM hotel;";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable SelectQuartosReservados()
        {
            DataTable dt = new DataTable();
            string query = "SELECT COUNT(id) FROM quarto;";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable SelectCountClientes()
        {
            DataTable dt = new DataTable();
            string query = "SELECT COUNT(id) FROM cliente;";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable SelectDespesa()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM despesa ORDER BY data_registro DESC;";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable SelectLucro()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM lucro ORDER BY data_registro DESC;";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable SelectLucrodespesa()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM lucro UNION ALL SELECT * FROM despesa ORDER BY data_registro DESC;";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable SelectLucroBrutoDia()
        {
            DataTable dt = new DataTable();
            string query = "SELECT SUM(valor)  AS total FROM lucro WHERE DATE(data_registro) = CURDATE();";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable SelectLucroBrutoSemana()
        {
            DataTable dt = new DataTable();
            string query = "SELECT sum(valor) AS total FROM lucro WHERE yearweek(data_registro) = yearweek(CURDATE());";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable SelectLucroBrutoMes()
        {
            DataTable dt = new DataTable();
            string query = "SELECT sum(valor) AS total FROM lucro WHERE MONTH(data_registro) = MONTH(CURDATE());";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable SelectLucroLiquidoDia()
        {
            DataTable dt = new DataTable();
            string query = "SELECT ((SELECT sum(valor) FROM lucro WHERE DATE(data_registro) = CURDATE()) - (SELECT sum(valor) FROM despesa WHERE DATE(data_registro) = CURDATE())) AS total;";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable SelectLucroLiquidoSemana()
        {
            DataTable dt = new DataTable();
            string query = "SELECT ((SELECT sum(valor) FROM lucro WHERE yearweek(data_registro) = yearweek(CURDATE())) - (SELECT sum(valor) FROM despesa WHERE yearweek(data_registro) = yearweek(CURDATE()))) AS total;";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable SelectLucroLiquidoMes()
        {
            DataTable dt = new DataTable();
            string query = "SELECT ((SELECT sum(valor) FROM lucro WHERE MONTH(data_registro) = MONTH(CURDATE())) - (SELECT sum(valor) FROM despesa WHERE MONTH(data_registro) = MONTH(CURDATE()))) AS total;";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable SelectDespesaDia()
        {
            DataTable dt = new DataTable();
            string query = "SELECT SUM(valor) AS total FROM lucro WHERE DATE(data_registro) = CURDATE();";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable SelectDespesaSemana()
        {
            DataTable dt = new DataTable();
            string query = "SELECT sum(valor)  AS total FROM despesa WHERE yearweek(data_registro) = yearweek(CURDATE());";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable SelectDespesaMes()
        {
            DataTable dt = new DataTable();
            string query = "SELECT sum(valor)  AS total FROM despesa WHERE MONTH(data_registro) = MONTH(CURDATE());";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable SelectCountUsuario(string usuario)
        {
            DataTable dt = new DataTable();
            string query = "SELECT count(id) FROM usuario WHERE usuario = '" + usuario + "';";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
