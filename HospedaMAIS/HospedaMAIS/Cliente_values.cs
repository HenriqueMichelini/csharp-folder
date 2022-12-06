using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospedaMAIS
{
    internal class Cliente_values
    {
        private static string cliente_id = "";
        private static string cliente_nome = "";    //  letra inicial minuscula.
        private static string cliente_sobrenome = "";
        private static string cliente_cidade = "";
        private static string cliente_unidade_federativa = "";
        private static string cliente_cpfcnpj = "";
        private static string cliente_cep = "";

        public string Cliente_id { get => cliente_id; set => cliente_id = value; }
        public string Cliente_nome { get => cliente_nome; set => cliente_nome = value; } //  letra inicial maiuscula.
        public string Cliente_sobrenome { get => cliente_sobrenome; set => cliente_sobrenome = value; }
        public string Cliente_cidade { get => cliente_cidade; set => cliente_cidade = value; }
        public string Cliente_unidade_federativa { get => cliente_unidade_federativa; set => cliente_unidade_federativa = value; }
        public string Cliente_cpfcnpj { get => cliente_cpfcnpj; set => cliente_cpfcnpj = value; }
        public string Cliente_cep { get => cliente_cep; set => cliente_cep = value; }

    }
}
