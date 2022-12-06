using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospedaMAIS
{
    internal class Quarto_values
    {
        private static string quarto_id = "";
        private static string quarto_hotel = "";
        private static string quarto_numero = "";
        private static string quarto_cliente = "";
        private static string quarto_unidade_federativa = "";
        private static string quarto_cpfcnpj = "";
        private static string quarto_acompanhantes = "";

        public string Quarto_id { get => quarto_id; set => quarto_id = value; }
        public string Quarto_hotel { get => quarto_hotel; set => quarto_hotel = value; }
        public string Quarto_numero { get => quarto_numero; set => quarto_numero = value; }
        public string Quarto_cliente { get => quarto_cliente; set => quarto_cliente = value; }
        public string Quarto_unidade_federativa { get => quarto_unidade_federativa; set => quarto_unidade_federativa = value; }
        public string Quarto_cpfcnpj { get => quarto_cpfcnpj; set => quarto_cpfcnpj = value; }
        public string Quarto_acompanhantes { get => quarto_acompanhantes; set => quarto_acompanhantes = value; }
    }
}
