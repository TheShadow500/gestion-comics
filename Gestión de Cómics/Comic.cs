using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Gestión_de_Cómics
{
    internal class Comic
    {
        private string Titulo { get; set; }
        private string Autor { get; set; }
        private string Editorial { get; set; }
        private int Fecha { get; set; }
        private string Resumen { get; set; }
        private string Portada { get; set; }
        private int CodigoBarras { get; set; }

        public Comic(string titulo, string autor, string editorial, int fecha, string resumen, string portada, int codigoBarras)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            Fecha = fecha;
            Resumen = resumen;
            Portada = portada;
            CodigoBarras = codigoBarras;
        }
    }
}
