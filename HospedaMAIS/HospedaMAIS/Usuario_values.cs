using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospedaMAIS
{
    internal class Usuario_values
    {
        private static string usuario_usuario = "";
        private static string usuario_senha = "";    //  letra inicial minuscula.

        public string Usuario_usuario { get => usuario_usuario; set => usuario_usuario = value; }
        public string Usuario_senha { get => usuario_senha; set => usuario_senha = value; } //  letra inicial maiuscula.
    }
}
