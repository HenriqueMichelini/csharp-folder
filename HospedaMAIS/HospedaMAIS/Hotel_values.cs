using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospedaMAIS
{
    internal class Hotel_values
    {
        private static string hotel_id = "";    //  letra inicial minuscula.
        private static string hotel_nome = "";
        private static string hotel_capital = "";
        private static string hotel_cidade = "";
        private static string hotel_unidade_federativa = "";
        private static string hotel_quartos = "";
        private static string hotel_funcionarios = "";
        private static string hotel_cnpj = "";

        public string Hotel_id { get => hotel_id; set => hotel_id = value; }
        public string Hotel_nome { get => hotel_nome; set => hotel_nome = value; } //  letra inicial maiuscula.
        public string Hotel_capital { get => hotel_capital; set => hotel_capital = value; }
        public string Hotel_cidade { get => hotel_cidade; set => hotel_cidade = value; }
        public string Hotel_unidade_federativa { get => hotel_unidade_federativa; set => hotel_unidade_federativa = value; }
        public string Hotel_quartos { get => hotel_quartos; set => hotel_quartos = value; }
        public string Hotel_funcionarios { get => hotel_funcionarios; set => hotel_funcionarios = value; }
        public string Hotel_cnpj { get => hotel_cnpj; set => hotel_cnpj = value; }
    }
}