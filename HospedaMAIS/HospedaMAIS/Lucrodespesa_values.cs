using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospedaMAIS
{
    internal class Lucrodespesa_values
    {
        private static string lucrodespesa_id = "";    //  letra inicial minuscula.
        private static string lucrodespesa_hotel_id = "";
        private static string lucrodespesa_valor = "";
        private static string lucrodespesa_data_registro = "";

        public string Lucrodespesa_id { get => lucrodespesa_id; set => lucrodespesa_id = value; }
        public string Lucrodespesa_hotel_id { get => lucrodespesa_hotel_id; set => lucrodespesa_hotel_id = value; } //  letra inicial maiuscula.
        public string Lucrodespesa_valor { get => lucrodespesa_valor; set => lucrodespesa_valor = value; }
        public string Lucrodespesa_data_registro { get => lucrodespesa_data_registro; set => lucrodespesa_data_registro = value; }
    }
}
